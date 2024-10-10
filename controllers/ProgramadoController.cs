using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microondas.Data; 

namespace Microondas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramadosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProgramadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Programado>>> Get()
        {
            return await _context.Programados.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Programado>> Get(int id)
        {
            var programado = await _context.Programados.FindAsync(id);

            if (programado == null)
            {
                return NotFound();
            }

            return programado;
        }

        [HttpPost]
        public async Task<ActionResult<Programado>> Post(Programado programado)
        {
            _context.Programados.Add(programado);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = programado.Id }, programado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Programado programado)
        {
            if (id != programado.Id)
            {
                return BadRequest();
            }

            _context.Entry(programado).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var programado = await _context.Programados.FindAsync(id);

            if (programado == null)
            {
                return NotFound();
            }

            _context.Programados.Remove(programado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
