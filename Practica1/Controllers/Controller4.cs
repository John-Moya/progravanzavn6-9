using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{
    public class Controller4 : Controller
    {
        // GET: Controller4
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult estadisticas()
        {
            return View();
        }

        public ActionResult procesos()
        {
            return View();
        }

        // GET: Controller4/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controller4/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controller4/Create
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

        // GET: Controller4/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controller4/Edit/5
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

        // GET: Controller4/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controller4/Delete/5
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
