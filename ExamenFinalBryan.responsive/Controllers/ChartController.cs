using Proyecto.application.Contracts;
using Proyecto.domain.Models;
using Proyecto.domain.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.responsive.Controllers
{
    [AllowAnonymous]
    public class ChartController : Controller
    {
        private readonly ILogger<HomeController> _Context;

        public ChartController(IApplicationDbContext context)
        {
            Context = context;
        }
        IApplicationDbContext Context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult resumenAuto()
        {

            List<VMAutos> Lista = (from tbauto in Context.Autos
                                   group tbauto by tbauto.Estado into grupo

                                   orderby grupo.Count() descending
                                   select new VMAutos
                                   {
                                       auto = grupo.Key,
                                       precio = grupo.Count(),
                                   }).ToList();

            return StatusCode(StatusCodes.Status200OK, Lista);
        }

        public IActionResult resumenVenta()
        {

            DateTime FechaInicio = DateTime.Now;
            FechaInicio = FechaInicio.AddDays(-15);

            List<VMVenta> Lista = (from tbventas in Context.Ventas
                                   where tbventas.Fecha_hora.Date >= FechaInicio.Date
                                   group tbventas by tbventas.Fecha_hora.Date into grupo
                                   select new VMVenta
                                   {
                                       fecha = grupo.Key.ToString("dd/MM/yyyy"),
                                       Id = grupo.Count(),
                                   }).ToList();



            return StatusCode(StatusCodes.Status200OK, Lista);
        }  

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
