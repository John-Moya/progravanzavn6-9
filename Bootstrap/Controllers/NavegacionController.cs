using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Controllers
{
    public class NavegacionController : Controller
    {
        // GET: NavegacionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NavegacionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NavegacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NavegacionController/Create
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

        // GET: NavegacionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NavegacionController/Edit/5
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

        // GET: NavegacionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NavegacionController/Delete/5
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
