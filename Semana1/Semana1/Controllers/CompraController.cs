using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana1.Controllers
{
    public class CompraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pago()
        {
            return View();
        }

        public IActionResult MisPagos()
        {
            return View();
        }
    }
}
