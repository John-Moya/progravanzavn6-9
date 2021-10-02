using Microsoft.AspNetCore.Mvc;

namespace TareaVeteriania_JustinGranados.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
