using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tarea1Veterinaria.Controllers
{
    public class AcercaDeController : Controller
    {
        // GET: AcercaDeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcercaDeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcercaDeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcercaDeController/Create
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

        // GET: AcercaDeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcercaDeController/Edit/5
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

        // GET: AcercaDeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcercaDeController/Delete/5
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
