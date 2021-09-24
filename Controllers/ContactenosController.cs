using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TareaUno.Controllers
{
    public class ContactenosController : Controller
    {
        // GET: /<controller>/
        public IActionResult contactenosGet()
        {
            return View();
        }
    }
}
