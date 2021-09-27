﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universidad.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: EstudiantesController
        public ActionResult AndresGonzalez()
        {
            return View();
        }
        public ActionResult DiegoCoto()
        {
            return View();
        }

        // GET: EstudiantesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudiantesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesController/Create
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

        // GET: EstudiantesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Edit/5
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

        // GET: EstudiantesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Delete/5
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
