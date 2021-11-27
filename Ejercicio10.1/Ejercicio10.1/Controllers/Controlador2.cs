using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio10._1.Controllers
{
    public class Controlador2 : Controller
    {
        // GET: Controlador1
        public ActionResult Vista2()
        {
            return View();
        }

        // GET: Controlador1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controlador1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controlador1/Create
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

        // GET: Controlador1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controlador1/Edit/5
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

        // GET: Controlador1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controlador1/Delete/5
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
