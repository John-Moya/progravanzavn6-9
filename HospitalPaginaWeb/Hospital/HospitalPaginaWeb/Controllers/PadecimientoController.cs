using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalPaginaWeb.Data;
using HospitalPaginaWeb.Models;

namespace HospitalPaginaWeb.Controllers
{
    public class PadecimientoController : Controller
    {
        private readonly HospitalPaginaWebContext _context;

        public PadecimientoController(HospitalPaginaWebContext context)
        {
            _context = context;
        }

        // GET: Padecimiento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Padecimiento.ToListAsync());
        }

        // GET: Padecimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padecimiento = await _context.Padecimiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (padecimiento == null)
            {
                return NotFound();
            }

            return View(padecimiento);
        }

        // GET: Padecimiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Padecimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombrePadecimiento,Tratamiento,Cedula,CedulaDoctor")] Padecimiento padecimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(padecimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(padecimiento);
        }

        // GET: Padecimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padecimiento = await _context.Padecimiento.FindAsync(id);
            if (padecimiento == null)
            {
                return NotFound();
            }
            return View(padecimiento);
        }

        // POST: Padecimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombrePadecimiento,Tratamiento,Cedula,CedulaDoctor")] Padecimiento padecimiento)
        {
            if (id != padecimiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(padecimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PadecimientoExists(padecimiento.Id))
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
            return View(padecimiento);
        }

        // GET: Padecimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var padecimiento = await _context.Padecimiento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (padecimiento == null)
            {
                return NotFound();
            }

            return View(padecimiento);
        }

        // POST: Padecimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var padecimiento = await _context.Padecimiento.FindAsync(id);
            _context.Padecimiento.Remove(padecimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PadecimientoExists(int id)
        {
            return _context.Padecimiento.Any(e => e.Id == id);
        }
    }
}
