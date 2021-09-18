using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Ventas()
        {
            return View();
        }

        public IActionResult RegistroVenta()
        {
            return View();
        }
    }
}
