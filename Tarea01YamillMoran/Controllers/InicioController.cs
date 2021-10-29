﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea01YamillMoran.Controllers
{
    public class InicioController : Controller
    {
        // GET: InicioController
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: InicioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InicioController/Create
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

        // GET: InicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InicioController/Edit/5
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

        // GET: InicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InicioController/Delete/5
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
