using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Municipalidad.Data;
using Municipalidad.Modelo;

namespace Municipalidad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParquimetrosController : ControllerBase
    {
        private readonly MunicipalidadContext _context;

        public ParquimetrosController(MunicipalidadContext context)
        {
            _context = context;
        }

        // GET: api/Parquimetros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parquimetros>>> GetParquimetros()
        {
            return await _context.Parquimetros.ToListAsync();
        }

        // GET: api/Parquimetros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parquimetros>> GetParquimetros(int id)
        {
            var parquimetros = await _context.Parquimetros.FindAsync(id);

            if (parquimetros == null)
            {
                return NotFound();
            }

            return parquimetros;
        }

        // PUT: api/Parquimetros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParquimetros(int id, Parquimetros parquimetros)
        {
            if (id != parquimetros.ID)
            {
                return BadRequest();
            }

            _context.Entry(parquimetros).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParquimetrosExists(id))
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

        // POST: api/Parquimetros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parquimetros>> PostParquimetros(Parquimetros parquimetros)
        {
            _context.Parquimetros.Add(parquimetros);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParquimetros", new { id = parquimetros.ID }, parquimetros);
        }

        // DELETE: api/Parquimetros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParquimetros(int id)
        {
            var parquimetros = await _context.Parquimetros.FindAsync(id);
            if (parquimetros == null)
            {
                return NotFound();
            }

            _context.Parquimetros.Remove(parquimetros);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParquimetrosExists(int id)
        {
            return _context.Parquimetros.Any(e => e.ID == id);
        }
    }
}
