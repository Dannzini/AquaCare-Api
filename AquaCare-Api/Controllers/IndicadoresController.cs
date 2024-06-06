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

        // GET: api/Indicadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Indicador>>> GetIndicadores()
        {
            return await _context.Indicadores.ToListAsync();
        }

        // GET: api/Indicadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Indicador>> GetIndicador(int id)
        {
            var indicador = await _context.Indicadores.FindAsync(id);

            if (indicador == null)
            {
                return NotFound();
            }

            return indicador;
        }

        // PUT: api/Indicadores/5
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

        // POST: api/Indicadores
        [HttpPost]
        public async Task<ActionResult<Indicador>> PostIndicador(Indicador indicador)
        {
            var existingLocal = await _context.Locais.FindAsync(indicador.CodigoLocal);
            if (existingLocal == null)
            {
                return BadRequest("Local não encontrado.");
            }

            indicador.Local = existingLocal;
            _context.Indicadores.Add(indicador);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIndicador), new { id = indicador.CodigoIndicador }, indicador);
        }

        // DELETE: api/Indicadores/5
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
