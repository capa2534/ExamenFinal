using Proyecto.application.Contracts;
using Proyecto.application.Handlers;
using Proyecto.domain.Models.DataModels;
using Proyecto.infraestructure.Data;
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
    //    public class VehiculoController : Controller
    //    {
    //        public VehiculoController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
    //        {
    //            UnitOfWork = unitOfWork;
    //            Repository = UnitOfWork.Repository<Vehiculo>();
    //            Context = context;
    //        }

    //        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
    //        readonly IRepository<Vehiculo> Repository;

    //        IApplicationDbContext Context;

    //        [Authorize(Policy = PermissionTypeNames.VIEWROLES)]
    //        public IActionResult Index()
    //        {
    //            return View(Repository.Listar());
    //        }


    //        [HttpGet]
    //        [Authorize(Policy = PermissionTypeNames.MANAGEROLES)]
    //        public IActionResult Upsert(string id)
    //        {
    //            Vehiculo myvehiculo = new Vehiculo();
    //            if (id == null)
    //            {
    //                return View(myvehiculo);
    //            }

    //            myvehiculo = Repository.Obtener(id);
    //            if (myvehiculo == null)
    //            {
    //                return NotFound();
    //            }

    //            return View(myvehiculo);
    //        }

    //        [HttpPost]
    //        [Authorize(Policy = PermissionTypeNames.MANAGEROLES)]
    //        public IActionResult Upsert(Vehiculo mycar)
    //        {

    //            if (ModelState.IsValid)
    //            {
    //                Vehiculo Val = Context.Vehiculos.Where(w => w.Placa == mycar.Placa).FirstOrDefault();


    //                if (Val == null)
    //                {
    //                    if (true)
    //                    {

    //                        mycar.UpdateValidation = 1;
    //                        Repository.Insertar(mycar);

    //                        UnitOfWork.Guardar();
    //                        return RedirectToAction(nameof(Index));
    //                    }

    //                }
    //                else
    //                {
    //                    Val.Placa = mycar.Placa;
    //                    Val.Marca = mycar.Marca;
    //                    Val.Modelo = mycar.Modelo;
    //                    Val.AñoFabricacion = mycar.AñoFabricacion;
    //                    Val.UpdateValidation = 1;

    //                    UnitOfWork.Guardar();
    //                    return RedirectToAction(nameof(Index));

    //                }


    //            }
    //            return View(mycar);
    //        }

    //        [HttpDelete]
    //        [Authorize(Policy = PermissionTypeNames.MANAGEROLES)]
    //        public IActionResult Delete(string id)
    //        {
    //            var mycar = Repository.Obtener(id);

    //            if (mycar == null)
    //            {
    //                return Json(new { success = false, message = $"No se encontró el vehiculo con la placa: {id}" });
    //            }

    //            Repository.Borrar(mycar);
    //            UnitOfWork.Guardar();

    //            return Json(new { success = true, message = "Se ha eliminado este vehiculo" });
    //        }

    //        [HttpGet]
    //        [AllowAnonymous]
    //        public IActionResult AccessDenied()
    //        {
    //            return View();
    //        }

    //        [Route("placavalidation")]
    //        //[AllowAnonymous]
    //        public async Task<JsonResult> placavalidation(string placa, int UpdateValidation)
    //        {

    //            Vehiculo Val = Context.Vehiculos.Where(w => w.Placa == placa).FirstOrDefault();

    //            if (Val == null)
    //            {
    //                return Json(true);
    //            }
    //            else if (Val != null && UpdateValidation == 1)
    //            {
    //                return Json(true);
    //            }
    //            else
    //            {
    //                return Json($"El siguiente numero de placa: {placa} ya existe en el sistema!");
    //            }

    //        }

    //    }
}
