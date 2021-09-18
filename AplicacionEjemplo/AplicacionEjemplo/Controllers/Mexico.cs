using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionEjemplo.Controllers
{
    public class Mexico : Controller
    {
        // GET: Mexico
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalles()
        {
            return View();
        }

        // GET: Mexico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mexico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mexico/Create
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

        // GET: Mexico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mexico/Edit/5
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

        // GET: Mexico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mexico/Delete/5
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
