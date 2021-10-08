using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Authorization;

namespace Hospital
{
    public class CuartoController : Controller
    {
        private readonly HospitalContext _context;

        public CuartoController(HospitalContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Cuarto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cuarto.ToListAsync());
        }

        // GET: Cuarto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuarto = await _context.Cuarto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuarto == null)
            {
                return NotFound();
            }

            return View(cuarto);
        }

        [Authorize]
        // GET: Cuarto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cuarto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumCuarto,TipoCuarto,Piso,Estado")] Cuarto cuarto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuarto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuarto);
        }

        // GET: Cuarto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuarto = await _context.Cuarto.FindAsync(id);
            if (cuarto == null)
            {
                return NotFound();
            }
            return View(cuarto);
        }

        // POST: Cuarto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumCuarto,TipoCuarto,Piso,Estado")] Cuarto cuarto)
        {
            if (id != cuarto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuarto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuartoExists(cuarto.Id))
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
            return View(cuarto);
        }

        // GET: Cuarto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuarto = await _context.Cuarto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuarto == null)
            {
                return NotFound();
            }

            return View(cuarto);
        }

        // POST: Cuarto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuarto = await _context.Cuarto.FindAsync(id);
            _context.Cuarto.Remove(cuarto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuartoExists(int id)
        {
            return _context.Cuarto.Any(e => e.Id == id);
        }
    }
}
