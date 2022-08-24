using Proyecto.application.Contracts;
using Proyecto.domain.Models.ConfigurationsModels;
using Proyecto.domain.Models.InputModels;
using Proyecto.domain.Models.MailModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Proyecto.responsive.Controllers
{
    [Route("accounts")]
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        public AccountsController
            (IOptions<ConfiguracionRecaptcha> configuracion, IRecaptchaValidator recaptcha,
                UserManager<IdentityUser> userManager, 
                SignInManager<IdentityUser> sessionManager,
                RoleManager<IdentityRole> roleManager,
                ICartero cartero
            )
        {
            Configuracion = configuracion.Value;
            Recaptcha = recaptcha;

            _userManager = userManager;
            _sessionManager = sessionManager;
            _roleManager = roleManager;
            Cartero = cartero;
        }

        ConfiguracionRecaptcha Configuracion;
        IRecaptchaValidator Recaptcha;

        ICartero Cartero;
        readonly UserManager<IdentityUser> _userManager;
        readonly SignInManager<IdentityUser> _sessionManager;
        readonly RoleManager<IdentityRole> _roleManager;

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            RegisterInputModel model =
                new RegisterInputModel();

            return View(model);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterInputModel model)
        {
            if (ModelState.IsValid)
            {
                var email = model.Email;

                var user =
                    new IdentityUser
                    {
                        UserName = email,
                        Email = email
                    };

                var result = await _userManager.CreateAsync(user, password: model.Password);

                if (result.Succeeded)
                {
                    await _sessionManager.SignInAsync(user, isPersistent: false);
                    var RoleByDefault = _roleManager.FindByNameAsync("Cliente").Result;

                    if (RoleByDefault != null)
                    {

                        IdentityResult roleresult = await _userManager.AddToRoleAsync(user, RoleByDefault.Name);
                        await _sessionManager.SignInAsync(user, isPersistent: false);

                    }

                    return RedirectToAction("index", "home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> Login()
        {

            //esto 
            LoginInputModel model =
                new LoginInputModel
                {
                    SiteKey = Configuracion.SiteKey,

                    //ExternalLogins =
                    //(await _sessionManager.GetExternalAuthenticationSchemesAsync()).ToList()
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("login")]
        public async Task<IActionResult> Login(LoginInputModel model)
        {
            if (ModelState.IsValid)
            {


                try
                {
                    var result =
                        await _sessionManager.PasswordSignInAsync
                    (model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);


                    if (Recaptcha.Validate(model.Recaptcha))
                    {

                        if (result.Succeeded)
                        {

                            return RedirectToAction("index", "home");
                        }

                    }


                }

                catch (Exception ex)
                {
                    string[] messages = ex.Message.Split("\n", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var message in messages)
                    {
                        ModelState.AddModelError(string.Empty, message);


                    }
                }
                return View(model);

            }
            return View(model);

        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _sessionManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }


        [Route("checkemail")]
        //[AllowAnonymous]
        public async Task<JsonResult> CheckEmail(string email)
        {
            var user =
                await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }

            return Json($"Cuenta {email} registrada anteriormente, por favor utilice un email diferente!");
        }

        [HttpGet]
        [Route("forgetpassword")]
        public IActionResult ForgetPassword()
        {
            ForgetPasswordInputModel model =
                new ForgetPasswordInputModel();

            return View(model);
        }


        [HttpPost]
        [Route("forgetpassword")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordInputModel model)
        {
            if (ModelState.IsValid)
            {
                var email = model.Email;

                var user =
                    await _userManager.FindByEmailAsync(email);

                if (user != null)
                {
                    var token =
                        await _userManager.GeneratePasswordResetTokenAsync(user);

                    var resetPasswordUrl =
                        string.Concat
                            (
                                Url.Action(nameof(ResetPassword)),
                                "?email=",
                                WebUtility.UrlEncode(email),
                                "&token=",
                                WebUtility.UrlEncode(token)
                            );

                    Cartero.Enviar
                        (
                            new CorreoElectronico
                            {
                                Destinatario = email,
                                Asunto = "Contraseña reenviada RE: Fidelitas Motors",
                                Cuerpo = "Haga clic en el siguiente enlace para proceder al cambio de contraseña de su cuenta:  " + "http://localhost:57492" + resetPasswordUrl, 
                            }
                        );
                }

                return View(nameof(ForgetPasswordConfirmation));
            }

            return View(model);
        }

        

        [Route("forgetpasswordconfirmation")]
        public IActionResult ForgetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [Route("resetpassword")]
        //[AllowAnonymous]
        public IActionResult ResetPassword(string email, string token)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token))
            {
                ModelState.AddModelError
                    (string.Empty, "Email y Token son requeridos!");
            }

            return View();
        }

        [HttpPost]
        [Route("resetpassword")]
        //[AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordInputModel model)
        {
            if (ModelState.IsValid)
            {
                var user =
                    await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    RedirectToAction("index", "home");
                }

                var result =
                    await _userManager.ResetPasswordAsync
                        (user, model.Token, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(ResetPasswordConfirmation));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }


        [Route("resetpasswordconfirmation")]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
