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
    public class SectorManagersController : ControllerBase
    {
        private readonly StarshipContext _context;

        public SectorManagersController(StarshipContext context)
        {
            _context = context;
        }

        // GET: api/SectorManagers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectorManager>>> GetSectorManager()
        {
            return await _context.SectorManager.ToListAsync();
        }

        // GET: api/SectorManagers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectorManager>> GetSectorManager(int id)
        {
            var sectorManager = await _context.SectorManager.FindAsync(id);

            if (sectorManager == null)
            {
                return NotFound();
            }

            return sectorManager;
        }

        // PUT: api/SectorManagers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSectorManager(int id, SectorManager sectorManager)
        {
            if (id != sectorManager.Id)
            {
                return BadRequest();
            }

            _context.Entry(sectorManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectorManagerExists(id))
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

        // POST: api/SectorManagers
        [HttpPost]
        public async Task<ActionResult<SectorManager>> PostSectorManager(SectorManager sectorManager)
        {
            _context.SectorManager.Add(sectorManager);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSectorManager", new { id = sectorManager.Id }, sectorManager);
        }

        // DELETE: api/SectorManagers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSectorManager(int id)
        {
            var sectorManager = await _context.SectorManager.FindAsync(id);
            if (sectorManager == null)
            {
                return NotFound();
            }

            _context.SectorManager.Remove(sectorManager);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SectorManagerExists(int id)
        {
            return _context.SectorManager.Any(e => e.Id == id);
        }
    }
}
