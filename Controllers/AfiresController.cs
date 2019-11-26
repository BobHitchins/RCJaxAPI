using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RCJaxWeb.Models;

namespace RCJaxWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AfiresController : ControllerBase
    {
        private readonly RcJaxWebContext _context;

        public AfiresController(RcJaxWebContext context)
        {
            _context = context;
        }

        // GET: api/Afires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Afire>>> GetAfire()
        {
            return await _context.Afire.ToListAsync();
        }

        // GET: api/Afires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Afire>> GetAfire(int id)
        {
            var afire = await _context.Afire.FindAsync(id);

            if (afire == null)
            {
                return NotFound();
            }

            return afire;
        }

        // PUT: api/Afires/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAfire(int id, Afire afire)
        {
            if (id != afire.Id)
            {
                return BadRequest();
            }

            _context.Entry(afire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AfireExists(id))
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

        // POST: api/Afires
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Afire>> PostAfire(Afire afire)
        {
            _context.Afire.Add(afire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAfire", new { id = afire.Id }, afire);
        }

        // DELETE: api/Afires/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Afire>> DeleteAfire(int id)
        {
            var afire = await _context.Afire.FindAsync(id);
            if (afire == null)
            {
                return NotFound();
            }

            _context.Afire.Remove(afire);
            await _context.SaveChangesAsync();

            return afire;
        }

        private bool AfireExists(int id)
        {
            return _context.Afire.Any(e => e.Id == id);
        }
    }
}
