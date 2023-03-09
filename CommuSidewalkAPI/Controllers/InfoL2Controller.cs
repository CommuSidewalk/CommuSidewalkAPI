using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommuSidewalkAPI.Models;

namespace CommuSidewalkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoL2Controller : ControllerBase
    {
        private readonly SidewalkContext _context;

        public InfoL2Controller(SidewalkContext context)
        {
            _context = context;
        }

        // GET: api/InfoL2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfoL2>>> GetInfoL2s()
        {
          if (_context.InfoL2s == null)
          {
              return NotFound();
          }
            return await _context.InfoL2s.ToListAsync();
        }

        // GET: api/InfoL2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InfoL2>> GetInfoL2(string id)
        {
          if (_context.InfoL2s == null)
          {
              return NotFound();
          }
            var infoL2 = await _context.InfoL2s.FindAsync(id);

            if (infoL2 == null)
            {
                return NotFound();
            }

            return infoL2;
        }

        // PUT: api/InfoL2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfoL2(string id, InfoL2 infoL2)
        {
            if (id != infoL2.Id)
            {
                return BadRequest();
            }

            _context.Entry(infoL2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoL2Exists(id))
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

        // POST: api/InfoL2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InfoL2>> PostInfoL2(InfoL2 infoL2)
        {
          if (_context.InfoL2s == null)
          {
              return Problem("Entity set 'SidewalkContext.InfoL2s'  is null.");
          }
            _context.InfoL2s.Add(infoL2);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InfoL2Exists(infoL2.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInfoL2", new { id = infoL2.Id }, infoL2);
        }

        // DELETE: api/InfoL2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfoL2(string id)
        {
            if (_context.InfoL2s == null)
            {
                return NotFound();
            }
            var infoL2 = await _context.InfoL2s.FindAsync(id);
            if (infoL2 == null)
            {
                return NotFound();
            }

            _context.InfoL2s.Remove(infoL2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InfoL2Exists(string id)
        {
            return (_context.InfoL2s?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
