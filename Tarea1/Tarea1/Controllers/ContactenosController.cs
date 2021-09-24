using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Controllers
{
    public class ContactenosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contactenos()
        {
            return View();
        }
    }
}
