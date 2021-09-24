using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{
    public class Controler1 : Controller
    {
        // GET: Controler1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bienvenida()
        {
            return View();
        }

        public ActionResult Informacion()
        {
            return View();
        }

        // GET: Controler1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Controler1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Controler1/Create
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

        // GET: Controler1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Controler1/Edit/5
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

        // GET: Controler1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Controler1/Delete/5
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
