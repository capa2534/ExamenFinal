using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.responsive.Controllers
{
    public class EnviarCorreoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
