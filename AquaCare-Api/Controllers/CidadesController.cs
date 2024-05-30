using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AquaCare_Api.Model;
using AquaCareAPI.Data;

namespace AquaCareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        private readonly DataContext _context;

        public CidadesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetCidades()
        {
            return await _context.Cidades.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cidade>> GetCidade(int id)
        {
            var cidade = await _context.Cidades.FindAsync(id);

            if (cidade == null)
            {
                return NotFound();
            }

            return cidade;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCidade(int id, Cidade cidade)
        {
            if (id != cidade.CodigoCidade)
            {
                return BadRequest();
            }

            _context.Entry(cidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CidadeExists(id))
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
        public async Task<ActionResult<Cidade>> PostCidade(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCidade), new { id = cidade.CodigoCidade }, cidade);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCidade(int id)
        {
            var cidade = await _context.Cidades.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }

            _context.Cidades.Remove(cidade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CidadeExists(int id)
        {
            return _context.Cidades.Any(e => e.CodigoCidade == id);
        }
    }
}