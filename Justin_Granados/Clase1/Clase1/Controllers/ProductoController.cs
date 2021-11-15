using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult RegistroProducto()
        {
            return View();
        }
    }
}
