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
    public class EncounterMaterialsController : ControllerBase
    {
        private readonly RcJaxWebContext _context;

        public EncounterMaterialsController(RcJaxWebContext context)
        {
            _context = context;
        }

        // GET: api/EncounterMaterials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EncounterMaterial>>> GetEncounterMaterial()
        {
            return await _context.EncounterMaterial.ToListAsync();
        }

        // GET: api/EncounterMaterials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EncounterMaterial>> GetEncounterMaterial(int id)
        {
            var encounterMaterial = await _context.EncounterMaterial.FindAsync(id);

            if (encounterMaterial == null)
            {
                return NotFound();
            }

            return encounterMaterial;
        }

        // PUT: api/EncounterMaterials/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEncounterMaterial(int id, EncounterMaterial encounterMaterial)
        {
            if (id != encounterMaterial.Id)
            {
                return BadRequest();
            }

            _context.Entry(encounterMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EncounterMaterialExists(id))
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

        // POST: api/EncounterMaterials
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<EncounterMaterial>> PostEncounterMaterial(EncounterMaterial encounterMaterial)
        {
            _context.EncounterMaterial.Add(encounterMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEncounterMaterial", new { id = encounterMaterial.Id }, encounterMaterial);
        }

        // DELETE: api/EncounterMaterials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EncounterMaterial>> DeleteEncounterMaterial(int id)
        {
            var encounterMaterial = await _context.EncounterMaterial.FindAsync(id);
            if (encounterMaterial == null)
            {
                return NotFound();
            }

            _context.EncounterMaterial.Remove(encounterMaterial);
            await _context.SaveChangesAsync();

            return encounterMaterial;
        }

        private bool EncounterMaterialExists(int id)
        {
            return _context.EncounterMaterial.Any(e => e.Id == id);
        }
    }
}
