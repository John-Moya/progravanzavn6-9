using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion_de_Ejemplo.Controllers
{
    public class SeriesController : Controller
    {
        // GET: SeriesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeriesController/Details/5
        public ActionResult Categorias()
        {
            return View();
        }

        // GET: SeriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SeriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SeriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SeriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
