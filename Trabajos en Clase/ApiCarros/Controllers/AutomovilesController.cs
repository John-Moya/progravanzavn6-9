using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCarros.Data;
using ApiCarros.Models;

namespace ApiCarros
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomovilesController : ControllerBase
    {
        private readonly ApiCarrosContext _context;

        public AutomovilesController(ApiCarrosContext context)
        {
            _context = context;
        }

        // GET: api/Automoviles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Automovil>>> GetAutomovil()
        {
            return await _context.Automovil.ToListAsync();
        }

        // GET: api/Automoviles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Automovil>> GetAutomovil(int id)
        {
            var automovil = await _context.Automovil.FindAsync(id);

            if (automovil == null)
            {
                return NotFound();
            }

            return automovil;
        }

        // PUT: api/Automoviles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutomovil(int id, Automovil automovil)
        {
            if (id != automovil.id)
            {
                return BadRequest();
            }

            _context.Entry(automovil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomovilExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Automoviles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Automovil>> PostAutomovil(Automovil automovil)
        {
            _context.Automovil.Add(automovil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutomovil", new { id = automovil.id }, automovil);
        }

        // DELETE: api/Automoviles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutomovil(int id)
        {
            var automovil = await _context.Automovil.FindAsync(id);
            if (automovil == null)
            {
                return NotFound();
            }

            _context.Automovil.Remove(automovil);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AutomovilExists(int id)
        {
            return _context.Automovil.Any(e => e.id == id);
        }
    }
}
