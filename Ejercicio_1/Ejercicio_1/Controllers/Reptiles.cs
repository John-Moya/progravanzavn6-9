using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Controllers
{
    public class Reptiles : Controller
    {

        public ActionResult Tortuga()
        {
            return View();
        }

        public ActionResult Serpiente()
        {
            return View();
        }
        // GET: Reptiles
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reptiles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reptiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reptiles/Create
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

        // GET: Reptiles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reptiles/Edit/5
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

        // GET: Reptiles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reptiles/Delete/5
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
