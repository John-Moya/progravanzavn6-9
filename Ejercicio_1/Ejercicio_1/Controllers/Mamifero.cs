using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Controllers
{
    public class Mamifero : Controller
    {

        public ActionResult Tigre()
        {
            return View();
        }

        public ActionResult Oso()
        {
            return View();
        }

        // GET: Mamifero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mamifero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mamifero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mamifero/Create
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

        // GET: Mamifero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mamifero/Edit/5
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

        // GET: Mamifero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mamifero/Delete/5
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
