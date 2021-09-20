using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion_de_Ejemplo.Controllers
{
    public class ComicsController : Controller
    {
        // GET: ComicsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ComicsController/Details/5
        public ActionResult Categorias()
        {
            return View();
        }

        // GET: ComicsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComicsController/Create
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

        // GET: ComicsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ComicsController/Edit/5
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

        // GET: ComicsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ComicsController/Delete/5
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
