
using ExamenFinalBryan.application;
using ExamenFinalBryan.application.Components;
using ExamenFinalBryan.application.Contracts;
using ExamenFinalBryan.domain.Models.ConfigurationsModels;
using ExamenFinalBryan.domain.Models.DataModels;
using ExamenFinalBryan.domain.Models.MailModels;
using ExamenFinalBryan.infraestructure;
using ExamenFinalBryan.infraestructure.Data;
using ExamenFinalBryan.infraestructure.Repositories;
using ExamenFinalBryan.infraestructure.Repository.UnitOfWork;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalBryan.responsive
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("Default")))
                    .AddUnitOfWork<ApplicationDbContext>()
                    .AddRepository<Auto, AutoRepository>()
                    .AddRepository<Cliente, ClienteRepository>()
                    .AddRepository<Empleado, EmpleadoRepository>()
                    .AddRepository<Ventas, VentasRepository>();


            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());

            services.RegisterApplicationServices(Configuration);
            services.RegisterInfrastructureServices(Configuration);

            services.AddSingleton<ICartero, Cartero>();
            services.Configure<ConfiguracionSmtp>(Configuration.GetSection("ConfiguracionSmtp"));

            services.Configure<ConfiguracionRecaptcha>(Configuration.GetSection("ConfiguracionRecaptcha"));

            services.AddSingleton<IRecaptchaValidator, RecaptchaValidator>();

            services.AddAuthentication
                (
                    options =>
                    {
                        options.DefaultScheme =
                            CookieAuthenticationDefaults.AuthenticationScheme;
                    }
                );

            services.ConfigureApplicationCookie
                (
                    options =>
                    {
                        options.LoginPath = new PathString("/Accounts/login");
                        options.LogoutPath = new PathString("/Accounts/logout");
                        options.AccessDeniedPath = new PathString("/Accounts/AccessDenied");
                        options.AccessDeniedPath = new PathString("/Administration/AccessDenied");
                        options.AccessDeniedPath = new PathString("/Vehiculo/AccessDenied");
                        options.AccessDeniedPath = new PathString("/Rent/AccessDenied");
                        options.Cookie.SameSite = SameSiteMode.Lax;
                    }
                );



            services.AddMvc
                (
                    options =>
                    {
                        var policy =
                            new AuthorizationPolicyBuilder()
                                    .RequireAuthenticatedUser()
                                    .Build();

                        options.Filters.Add
                            (new AuthorizeFilter(policy));
                    }
                )
                .AddXmlSerializerFormatters();

            services.Configure<IdentityOptions>
                (
                    options =>
                    {
                        options.Password.RequiredLength = 6;
                        options.Password.RequiredUniqueChars = 3;
                        options.Password.RequireUppercase = true;
                        options.Password.RequireLowercase = true;
                        options.Password.RequireDigit = true;
                        options.Password.RequireNonAlphanumeric = true;
                    }
                );

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy
                (
                    new CookiePolicyOptions
                    {
                        MinimumSameSitePolicy = SameSiteMode.Lax
                    }
                );
          
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
