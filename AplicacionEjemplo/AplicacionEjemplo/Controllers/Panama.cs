using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionEjemplo.Controllers
{
    public class Panama : Controller
    {
        // GET: Panama
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalles()
        {
            return View();
        }

        // GET: Panama/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Panama/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Panama/Create
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

        // GET: Panama/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Panama/Edit/5
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

        // GET: Panama/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Panama/Delete/5
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
