using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AquaCare_Api.Model;
using AquaCareAPI.Data;

namespace AquaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocaisController : ControllerBase
    {
        private readonly DataContext _context;

        public LocaisController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Local>>> GetLocais()
        {
            return await _context.Locais.Include(l => l.Cidade).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Local>> GetLocal(int id)
        {
            var local = await _context.Locais.Include(l => l.Cidade).FirstOrDefaultAsync(l => l.CodigoLocal == id);

            if (local == null)
            {
                return NotFound();
            }

            return local;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocal(int id, Local local)
        {
            if (id != local.CodigoLocal)
            {
                return BadRequest();
            }

            _context.Entry(local).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Local>> PostLocal(Local local)
        {
            _context.Locais.Add(local);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLocal), new { id = local.CodigoLocal }, local);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocal(int id)
        {
            var local = await _context.Locais.FindAsync(id);
            if (local == null)
            {
                return NotFound();
            }

            _context.Locais.Remove(local);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocalExists(int id)
        {
            return _context.Locais.Any(e => e.CodigoLocal == id);
        }
    }
}
