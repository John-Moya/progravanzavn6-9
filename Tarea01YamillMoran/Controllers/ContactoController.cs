using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01YamillMoran.Controllers
{
    public class ContactoController : Controller
    {
        // GET: ContactoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactoController/Create
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

        // GET: ContactoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactoController/Edit/5
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

        // GET: ContactoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactoController/Delete/5
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
