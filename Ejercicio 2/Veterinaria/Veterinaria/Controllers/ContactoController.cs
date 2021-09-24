using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Contacto()
        {
            return View();
        }
    }
}
