using Proyecto.application.Contracts;
using Proyecto.domain.Models.DataModels;
using Proyecto.domain.Models.DataTransferModels;
using Proyecto.domain.Models.MailModels;
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

    public class VentasController : Controller
    {
        public VentasController(IUnitOfWork<ApplicationDbContext> unitOfWork, IApplicationDbContext context)
        {
            UnitOfWork = unitOfWork;
            Repository = UnitOfWork.Repository<Ventas>();
            Context = context;
        }
        readonly IUnitOfWork<ApplicationDbContext> UnitOfWork;
        readonly IRepository<Ventas> Repository;
        IApplicationDbContext Context;

        public IActionResult Index(int id = 0)
        {

            return View(Repository.Listar());
        }

        public IActionResult Upsert(int? id)
        {

            List<Cliente> clientes = Context.Clientes.ToList();
            List<Auto> autos = Context.Autos.ToList();
            List<Empleado> empleados = Context.Empleados.ToList();

            Ventas Ventas
                = new Ventas
                {
                    Clientes =
                        clientes.ConvertAll<Elemento2>
                            (s => new Elemento2(s.Id, s.Cedula)),
                    Autos =
                        autos.ConvertAll<Elemento3>
                            (s => new Elemento3(s.Id, s.Placa)),
                    Empleados =
                        empleados.ConvertAll<Elemento2>
                            (s => new Elemento2(s.Id, s.Cedula)),
                };


            if (id == null)
            {
                return View(Ventas);
            }

            Ventas = Repository.Obtener(id.GetValueOrDefault());
            if (Ventas == null)
            {
                return NotFound();
            }

            return View(Ventas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Ventas Ventas)
        {


            if (ModelState.IsValid)
            {
                if (Ventas.Id == 0)
                {
                    Ventas.Fecha_hora = System.DateTime.Now;
                    Ventas.Id_Auto = Ventas.Id_Auto;
                    Repository.Insertar(Ventas);



                }
                else
                {
                    Ventas.Fecha_hora = System.DateTime.Now;
                    Repository.Actualizar(Ventas);
                }

                UnitOfWork.Guardar();
                return RedirectToAction(nameof(Index));
            }

            return View(Ventas);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var Ventas = Repository.Obtener(id);

            if (Ventas == null)  //ver esto bien
            {
                return Json(new { success = false, message = $"Error con id {id}" });
            }

            Repository.Borrar(Ventas);
            UnitOfWork.Guardar();

            return Json(new { success = true, message = "Eliminado exitosamente." });
        }

        [HttpGet]
        [Route("/api/ventas/upsert/objcliente")]
        public IActionResult ListarObjCliente(int Id)
        {
            List<Cliente> cliente =
                Context.Clientes.Where(w => w.Id == Id).ToList();

            var contentido =
                new
                {
                    success = cliente != null || cliente.Count == 0,
                    content = cliente,
                    error =
                        cliente == null || cliente.Count == 0
                            ? "No se han encontrado ningun estudiante"
                            : string.Empty
                };

            return Json(contentido);
        }

        [HttpGet]
        [Route("/api/ventas/upsert/objauto")]
        public IActionResult ListarObjAuto(int Id)
        {
            List<Auto> auto =
                Context.Autos.Where(w => w.Id == Id).ToList();

            var contentido =
                new
                {
                    success = auto != null || auto.Count == 0,
                    content = auto,
                    error =
                        auto == null || auto.Count == 0
                            ? "No se han encontrado ningun estudiante"
                            : string.Empty
                };

            return Json(contentido);
        }

        [HttpGet]
        [Route("/api/ventas/upsert/objempleado")]
        public IActionResult ListarObjEmpleado(int Id)
        {
            List<Empleado> empleado =
                Context.Empleados.Where(w => w.Id == Id).ToList();

            var contentido =
                new
                {
                    success = empleado != null || empleado.Count == 0,
                    content = empleado,
                    error =
                        empleado == null || empleado.Count == 0
                            ? "No se han encontrado ningun estudiante"
                            : string.Empty
                };

            return Json(contentido);
        }


    }
}
