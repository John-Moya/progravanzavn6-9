using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Controllers
{
    public class SucursalesController : Controller
    {
        // GET: SucursalesController
        public ActionResult SanPedro()
        {
            return View();
        }
        public ActionResult Heredia()
        {
            return View();
        }

        // GET: SucursalesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SucursalesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SucursalesController/Create
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

        // GET: SucursalesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SucursalesController/Edit/5
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

        // GET: SucursalesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SucursalesController/Delete/5
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
