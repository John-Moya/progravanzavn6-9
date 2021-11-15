using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccesoriosProyecto.Data;
using AccesoriosProyecto.Models;

namespace AccesoriosProyecto
{
    public class AccesoriosController : Controller
    {
        private readonly AccesoriosProyectoContext _context;

        public AccesoriosController(AccesoriosProyectoContext context)
        {
            _context = context;
        }

        // GET: Accesorios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accesorios.ToListAsync());
        }

        // GET: Accesorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorios = await _context.Accesorios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accesorios == null)
            {
                return NotFound();
            }

            return View(accesorios);
        }

        // GET: Accesorios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accesorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Articulo,Descripcion,Precio,Cantidad,Tipo,Impuesto")] Accesorios accesorios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accesorios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accesorios);
        }

        // GET: Accesorios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorios = await _context.Accesorios.FindAsync(id);
            if (accesorios == null)
            {
                return NotFound();
            }
            return View(accesorios);
        }

        // POST: Accesorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Articulo,Descripcion,Precio,Cantidad,Tipo,Impuesto")] Accesorios accesorios)
        {
            if (id != accesorios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accesorios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccesoriosExists(accesorios.Id))
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
            return View(accesorios);
        }

        // GET: Accesorios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorios = await _context.Accesorios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accesorios == null)
            {
                return NotFound();
            }

            return View(accesorios);
        }

        // POST: Accesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accesorios = await _context.Accesorios.FindAsync(id);
            _context.Accesorios.Remove(accesorios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccesoriosExists(int id)
        {
            return _context.Accesorios.Any(e => e.Id == id);
        }
    }
}
