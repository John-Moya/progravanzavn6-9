using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana1.Controllers
{
    public class TiendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informacion()
        {
            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }
    }

}
