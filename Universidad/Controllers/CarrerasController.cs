using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Controllers
{
    public class CarrerasController : Controller
    {
        // GET: CarrerasController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IngenieriaIndustrial()
        {
            return View();
        }

        public ActionResult IngenieriaSistemas()
        {
            return View();
        }

        // GET: CarrerasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarrerasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarrerasController/Create
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

        // GET: CarrerasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarrerasController/Edit/5
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

        // GET: CarrerasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarrerasController/Delete/5
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
