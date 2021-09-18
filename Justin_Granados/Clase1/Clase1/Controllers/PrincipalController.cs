using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }
    }
}
