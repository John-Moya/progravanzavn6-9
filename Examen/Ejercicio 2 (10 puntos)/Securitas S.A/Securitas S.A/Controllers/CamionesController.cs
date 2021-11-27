using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Securitas_S.A_.Data;
using Securitas_S.A_.Modelo;

namespace Securitas_S.A_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionesController : ControllerBase
    {
        private readonly Securitas_SA_Context _context;

        public CamionesController(Securitas_SA_Context context)
        {
            _context = context;
        }

        // GET: api/Camiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Camiones>>> GetCamiones()
        {
            return await _context.Camiones.ToListAsync();
        }

        // GET: api/Camiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Camiones>> GetCamiones(int id)
        {
            var camiones = await _context.Camiones.FindAsync(id);

            if (camiones == null)
            {
                return NotFound();
            }

            return camiones;
        }

        // PUT: api/Camiones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCamiones(int id, Camiones camiones)
        {
            if (id != camiones.ID)
            {
                return BadRequest();
            }

            _context.Entry(camiones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CamionesExists(id))
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

        // POST: api/Camiones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Camiones>> PostCamiones(Camiones camiones)
        {
            _context.Camiones.Add(camiones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCamiones", new { id = camiones.ID }, camiones);
        }

        // DELETE: api/Camiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCamiones(int id)
        {
            var camiones = await _context.Camiones.FindAsync(id);
            if (camiones == null)
            {
                return NotFound();
            }

            _context.Camiones.Remove(camiones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CamionesExists(int id)
        {
            return _context.Camiones.Any(e => e.ID == id);
        }
    }
}
