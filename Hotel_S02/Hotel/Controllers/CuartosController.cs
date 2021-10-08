using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel.Data;
using Hotel.Models;

namespace Hotel
{
    public class CuartosController : Controller
    {
        private readonly HotelContext _context;

        public CuartosController(HotelContext context)
        {
            _context = context;
        }

        // GET: Cuartos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cuartos.ToListAsync());
        }

        // GET: Cuartos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuartos = await _context.Cuartos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuartos == null)
            {
                return NotFound();
            }

            return View(cuartos);
        }

        // GET: Cuartos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cuartos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumCuarto,TipoCuarto,Precio,Piso,Estado")] Cuartos cuartos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuartos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuartos);
        }

        // GET: Cuartos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuartos = await _context.Cuartos.FindAsync(id);
            if (cuartos == null)
            {
                return NotFound();
            }
            return View(cuartos);
        }

        // POST: Cuartos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumCuarto,TipoCuarto,Precio,Piso,Estado")] Cuartos cuartos)
        {
            if (id != cuartos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuartos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuartosExists(cuartos.Id))
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
            return View(cuartos);
        }

        // GET: Cuartos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuartos = await _context.Cuartos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuartos == null)
            {
                return NotFound();
            }

            return View(cuartos);
        }

        // POST: Cuartos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuartos = await _context.Cuartos.FindAsync(id);
            _context.Cuartos.Remove(cuartos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuartosExists(int id)
        {
            return _context.Cuartos.Any(e => e.Id == id);
        }
    }
}
