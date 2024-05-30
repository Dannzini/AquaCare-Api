using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AquaCare_Api.Model;
using AquaCareAPI.Data;

namespace AquaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadoresController : ControllerBase
    {
        private readonly DataContext _context;

        public IndicadoresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Indicador>>> GetIndicadores()
        {
            return await _context.Indicadores.Include(i => i.Local).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Indicador>> GetIndicador(int id)
        {
            var indicador = await _context.Indicadores.Include(i => i.Local).FirstOrDefaultAsync(i => i.CodigoIndicador == id);

            if (indicador == null)
            {
                return NotFound();
            }

            return indicador;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndicador(int id, Indicador indicador)
        {
            if (id != indicador.CodigoIndicador)
            {
                return BadRequest();
            }

            _context.Entry(indicador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndicadorExists(id))
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
        public async Task<ActionResult<Indicador>> PostIndicador(Indicador indicador)
        {
            _context.Indicadores.Add(indicador);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIndicador), new { id = indicador.CodigoIndicador }, indicador);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndicador(int id)
        {
            var indicador = await _context.Indicadores.FindAsync(id);
            if (indicador == null)
            {
                return NotFound();
            }

            _context.Indicadores.Remove(indicador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IndicadorExists(int id)
        {
            return _context.Indicadores.Any(e => e.CodigoIndicador == id);
        }
    }
}