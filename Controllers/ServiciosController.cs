using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1_NSB.Controllers
{
    public class Servicios : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Acerca()
        {
            return View();
        }

    }
}
