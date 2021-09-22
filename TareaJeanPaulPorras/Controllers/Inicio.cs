using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TareaJeanPaulPorras.Models;

namespace TareaJeanPaulPorras.Controllers
{
    public class Inicio : Controller
    {
        
            private readonly ILogger<Inicio> _logger;

            public Inicio(ILogger<Inicio> logger)
            {
                _logger = logger;
            }

            public IActionResult inicio()
            {
                return View();
            }

          
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
