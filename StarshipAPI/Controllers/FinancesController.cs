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
    public class FinancesController : ControllerBase
    {
        private readonly StarshipContext _context;

        public FinancesController(StarshipContext context)
        {
            _context = context;
        }

        // GET: api/Finances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Finance>>> GetFinance()
        {
            return await _context.Finance.ToListAsync();
        }

        // GET: api/Finances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Finance>> GetFinance(int id)
        {
            var finance = await _context.Finance.FindAsync(id);

            if (finance == null)
            {
                return NotFound();
            }

            return finance;
        }

        // PUT: api/Finances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFinance(int id, Finance finance)
        {
            if (id != finance.Id)
            {
                return BadRequest();
            }

            _context.Entry(finance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinanceExists(id))
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

        // POST: api/Finances
        [HttpPost]
        public async Task<ActionResult<Finance>> PostFinance(Finance finance)
        {
            _context.Finance.Add(finance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinance", new { id = finance.Id }, finance);
        }

        // DELETE: api/Finances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinance(int id)
        {
            var finance = await _context.Finance.FindAsync(id);
            if (finance == null)
            {
                return NotFound();
            }

            _context.Finance.Remove(finance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FinanceExists(int id)
        {
            return _context.Finance.Any(e => e.Id == id);
        }
    }
}
