using Proyecto.application.Contracts;
using Proyecto.domain.Models.DataModels;
using Proyecto.infraestructure.Data;
using Proyecto.infraestructure.Repository;
using Proyecto.infraestructure.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.responsive.Controllers
{

    public class ClienteController : Controller
    {

        public ClienteController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
        {
            UnitOfWork = unitOfWork;
            Repository = UnitOfWork.Repository<Cliente>();
            Context = context;
        }
        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
        readonly IRepository<Cliente> Repository;
        IApplicationDbContext Context;

        public IActionResult Index(int id = 0)
        {

            return View(Repository.Listar());
        }

        public IActionResult Upsert(int? id)
        {


            Cliente Cliente
                = new Cliente
                {

                };


            if (id == null)
            {
                return View(Cliente);
            }

            Cliente = Repository.Obtener(id.GetValueOrDefault());
            if (Cliente == null)
            {
                return NotFound();
            }

            return View(Cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Cliente Cliente)
        {


            if (ModelState.IsValid)
            {
                if (Cliente.Id == 0)
                {
                    Repository.Insertar(Cliente);

                }
                else
                {
                    Repository.Actualizar(Cliente);
                }

                UnitOfWork.Guardar();
                return RedirectToAction(nameof(Index));
            }

            return View(Cliente);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var Cliente = Repository.Obtener(id);

            if (Cliente == null)  //ver esto bien
            {
                return Json(new { success = false, message = $"No se encuentra el Cliente con id {id}" });
            }

            Repository.Borrar(Cliente);
            UnitOfWork.Guardar();

            return Json(new { success = true, message = "Cliente eliminado exitosamente." });
        }
    }
}
