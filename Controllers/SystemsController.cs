using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IdentityManagerAPI.Context;
using IdentityManagerAPI.Models;

namespace IdentityManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemsController : ControllerBase
    {
        private readonly IdentityContext _context;

        public SystemsController(IdentityContext context)
        {
            _context = context;
        }

        // GET: api/Systems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Systems>>> GetSystems()
        {
            return await _context.Systems.ToListAsync();
        }

        // GET: api/Systems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Systems>> GetSystems(int id)
        {
            var systems = await _context.Systems.FindAsync(id);

            if (systems == null)
            {
                return NotFound();
            }

            return systems;
        }

        // PUT: api/Systems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystems(int id, Systems systems)
        {
            if (id != systems.Id)
            {
                return BadRequest();
            }

            _context.Entry(systems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemsExists(id))
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

        // POST: api/Systems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Systems>> PostSystems(Systems systems)
        {
            _context.Systems.Add(systems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSystems", new { id = systems.Id }, systems);
        }

        // DELETE: api/Systems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystems(int id)
        {
            var systems = await _context.Systems.FindAsync(id);
            if (systems == null)
            {
                return NotFound();
            }

            _context.Systems.Remove(systems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SystemsExists(int id)
        {
            return _context.Systems.Any(e => e.Id == id);
        }
    }
}
