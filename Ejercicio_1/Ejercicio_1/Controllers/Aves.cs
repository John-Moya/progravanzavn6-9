using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Controllers
{
    public class Aves : Controller
    {
        [HttpGet]
        public ActionResult Alcon()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Loro()
        {
            return View();
        }

        // GET: Aves
        public ActionResult Index()
        {
            return View();
        }

        // GET: Aves/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Aves/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aves/Create
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

        // GET: Aves/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aves/Edit/5
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

        // GET: Aves/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aves/Delete/5
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
