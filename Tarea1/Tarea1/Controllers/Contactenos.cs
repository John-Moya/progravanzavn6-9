using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Controllers
{
    public class Contactenos : Controller
    {

        public ActionResult Contacto()
        {
            return View();
        }
        // GET: Contactenos
        public ActionResult Index()
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
