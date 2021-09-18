using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionEjemplo.Controllers
{
    public class Brasil : Controller
    {
        // GET: Brasil
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detalles()
        {
            return View();
        }
        // GET: Brasil/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Brasil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brasil/Create
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

        // GET: Brasil/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Brasil/Edit/5
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

        // GET: Brasil/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brasil/Delete/5
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
