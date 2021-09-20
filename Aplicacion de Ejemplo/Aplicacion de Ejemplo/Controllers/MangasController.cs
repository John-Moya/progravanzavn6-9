using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion_de_Ejemplo.Controllers
{
    public class MangasController : Controller
    {
        // GET: MangasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MangasController/Details/5
        public ActionResult Categorias()
        {
            return View();
        }

        // GET: MangasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MangasController/Create
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

        // GET: MangasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MangasController/Edit/5
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

        // GET: MangasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MangasController/Delete/5
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
