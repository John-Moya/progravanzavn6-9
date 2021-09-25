using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Controllers
{
    public class Peces : Controller
    {
        public ActionResult Payaso()
        {
            return View();
        }

        public ActionResult Globo ()
        {
            return View();
        }

        // GET: Peces
        public ActionResult Index()
        {
            return View();
        }

        // GET: Peces/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Peces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peces/Create
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

        // GET: Peces/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peces/Edit/5
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

        // GET: Peces/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peces/Delete/5
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
