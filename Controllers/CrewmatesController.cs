using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarshipAPI.Models;

namespace StarshipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrewmatesController : ControllerBase
    {
        private readonly StarshipContext _context;

        public CrewmatesController(StarshipContext context)
        {
            _context = context;
        }

        // GET: api/Crewmates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crewmate>>> GetCrewmates()
        {
            return await _context.Crewmates.ToListAsync();
        }

        // GET: api/Crewmates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crewmate>> GetCrewmate(long id)
        {
            var crewmate = await _context.Crewmates.FindAsync(id);

            if (crewmate == null)
            {
                return NotFound();
            }

            return crewmate;
        }

        // PUT: api/Crewmates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrewmate(long id, Crewmate crewmate)
        {
            if (id != crewmate.Id)
            {
                return BadRequest();
            }

            _context.Entry(crewmate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrewmateExists(id))
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

        // POST: api/Crewmates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Crewmate>> PostCrewmate(Crewmate crewmate)
        {
            _context.Crewmates.Add(crewmate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCrewmate), new { id = crewmate.Id }, crewmate);
        }

        // DELETE: api/Crewmates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrewmate(long id)
        {
            var crewmate = await _context.Crewmates.FindAsync(id);
            if (crewmate == null)
            {
                return NotFound();
            }

            _context.Crewmates.Remove(crewmate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CrewmateExists(long id)
        {
            return _context.Crewmates.Any(e => e.Id == id);
        }
    }
}
