using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarshipAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace StarshipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipsController : ControllerBase
    {
        private readonly StarshipContext _context;

        public ShipsController(StarshipContext context)
        {
            _context = context;
        }

        // GET: api/Ships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShip()
        {
            return await _context.Ship.ToListAsync();
        }

        // GET: api/Ships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ship>> GetShip(long id)
        {
            var ship = await _context.Ship.FindAsync(id);

            if (ship == null)
            {
                return NotFound();
            }

            return ship;
        }

        // PUT: api/Ships/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShip(long id, Ship ship)
        {
            if (id != ship.Id)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShipExists(id))
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

        // POST: api/Ships
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Ship>> PostShip(Ship ship)
        {
            _context.Ship.Add(ship);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetShip), new { id = ship.Id }, ship);
        }

        // DELETE: api/Ships/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip(long id)
        {
            var ship = await _context.Ship.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Ship.Remove(ship);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShipExists(long id)
        {
            return _context.Ship.Any(e => e.Id == id);
        }
    }
}
