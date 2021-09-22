using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaJeanPaulPorras.Controllers
{
    public class Contactenos : Controller
    {
        // GET: Contactenos
        public ActionResult contactenos()
        {
            return View();
        }

        // GET: Contactenos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contactenos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contactenos/Create
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

        // GET: Contactenos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contactenos/Edit/5
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

        // GET: Contactenos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contactenos/Delete/5
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
