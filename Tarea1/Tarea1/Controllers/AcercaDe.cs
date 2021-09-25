  using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Controllers
{
    public class AcercaDe : Controller
    {

        public ActionResult Acerca()
        {
            return View();
        }
        // GET: AcercaDe
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcercaDe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcercaDe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcercaDe/Create
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

        // GET: AcercaDe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcercaDe/Edit/5
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

        // GET: AcercaDe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcercaDe/Delete/5
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
