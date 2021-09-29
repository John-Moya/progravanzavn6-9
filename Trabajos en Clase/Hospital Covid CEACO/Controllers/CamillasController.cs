using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital_Covid_CEACO.Data;
using Hospital_Covid_CEACO.Models;

namespace Hospital_Covid_CEACO
{
    public class CamillasController : Controller
    {
        private readonly Hospital_Covid_CEACOContext _context;

        public CamillasController(Hospital_Covid_CEACOContext context)
        {
            _context = context;
        }

        // GET: Camillas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Camillas.ToListAsync());
        }

        // GET: Camillas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camillas = await _context.Camillas
                .FirstOrDefaultAsync(m => m.cedula == id);
            if (camillas == null)
            {
                return NotFound();
            }

            return View(camillas);
        }

        // GET: Camillas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Camillas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cedula,nombre,primerApellido,segundoApellido,numeroCamilla,estadoDeIngreso")] Camillas camillas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camillas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(camillas);
        }

        // GET: Camillas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camillas = await _context.Camillas.FindAsync(id);
            if (camillas == null)
            {
                return NotFound();
            }
            return View(camillas);
        }

        // POST: Camillas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cedula,nombre,primerApellido,segundoApellido,numeroCamilla,estadoDeIngreso")] Camillas camillas)
        {
            if (id != camillas.cedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camillas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CamillasExists(camillas.cedula))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(camillas);
        }

        // GET: Camillas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var camillas = await _context.Camillas
                .FirstOrDefaultAsync(m => m.cedula == id);
            if (camillas == null)
            {
                return NotFound();
            }

            return View(camillas);
        }

        // POST: Camillas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var camillas = await _context.Camillas.FindAsync(id);
            _context.Camillas.Remove(camillas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CamillasExists(int id)
        {
            return _context.Camillas.Any(e => e.cedula == id);
        }
    }
}
