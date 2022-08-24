using Proyecto.application.Contracts;
using Proyecto.application.Handlers;
using Proyecto.domain.Models.DataModels;
using Proyecto.infraestructure.Data;
using Proyecto.infraestructure.Repositories;
using Proyecto.infraestructure.Repository;
using Proyecto.infraestructure.Repository.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.responsive.Controllers
{
    //public class RentController : Controller
    //{
    //    public RentController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
    //    {
    //        UnitOfWork = unitOfWork;
    //        Repository = UnitOfWork.Repository<Rent>();
    //        VehiculoRepository = UnitOfWork.Repository<Vehiculo>();
    //        Context = context;
    //    }

    //    readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
    //    readonly IRepository<Rent> Repository;
    //    readonly IRepository<Vehiculo> VehiculoRepository;

    //    IApplicationDbContext Context;

    //    [Authorize(Policy = PermissionTypeNames.VIEWROLES)]
    //    public IActionResult Index()
    //    {
    //        return View(Repository.Listar());
    //    }

    //    [HttpPost]
    //    [Authorize(Policy = PermissionTypeNames.VIEWROLES)]
    //    public IActionResult RentCar(string id)
    //    {

    //        System.Security.Claims.ClaimsPrincipal currentUser = this.User;


    //        Vehiculo cartorent = VehiculoRepository.Obtener(id);
    //        string usertorent = currentUser.Identity.Name;
    //        string placatorent = cartorent.Placa.ToString();
    //        string rentDate = DateTime.Now.ToString();
    //        Rent rentRequest =
    //            new Rent
    //            {
    //                Date = rentDate.Substring(0,9),
    //                User = usertorent, 
    //                Placa = placatorent, 
    //                Status = "PENDIENTE", 
    //            };

    //        Repository.Insertar(rentRequest);
    //        UnitOfWork.Guardar();

    //        return View();
    //    }

    //    [HttpGet]
    //    [Authorize(Policy = PermissionTypeNames.MANAGEROLES)]
    //    public IActionResult Approve(int id)
    //    {
    //        var rent = Repository.Obtener(id);
    //        rent.Status = "APROBADO";
    //        Repository.Actualizar(rent);
    //        UnitOfWork.Guardar();

    //        List<Rent> Val = Context.Rents.Where(x => x.Placa == rent.Placa && x.Status == "PENDIENTE").ToList();

    //        foreach (var item in Val)
    //        {
    //            item.Status = "DENEGADO";
    //            Repository.Actualizar(item);
    //            UnitOfWork.Guardar();
    //        }

             
    //        var contentido =
    //            new
    //            {
    //                    resultado = ""
    //            };

    //        return Json(contentido);

    //    }

    //    [HttpGet]
    //    [Authorize(Policy = PermissionTypeNames.MANAGEROLES)]
    //    public IActionResult Deny(int id)
    //    {
    //        var rent = Repository.Obtener(id);
    //        rent.Status = "DENEGADO";
    //        Repository.Actualizar(rent);
    //        UnitOfWork.Guardar();



    //        var contentido =
    //            new
    //            {
    //                resultado = ""
    //            };

    //        return Json(contentido);
    //    }

    //    [HttpGet]
    //    [AllowAnonymous]
    //    public IActionResult AccessDenied()
    //    {
    //        return View();
    //    }

    //}
}
