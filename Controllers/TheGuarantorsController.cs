using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Guarantee.Models;

namespace WebApplication1.Controllers
{
    [Route("api/TheGuarantor")]
    [ApiController]
    public class TheGuarantorsController : ControllerBase
    {
        private readonly GuarContext _context;

        public TheGuarantorsController(GuarContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TheGuarantor>>> GGetTheGuarantors()
        {
            return await _context.TheGuarantors.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TheGuarantor>> GetTheGuarantor(int Id)
        {
            var theGuarantor = await _context.TheGuarantors.FindAsync(Id);

            if (theGuarantor == null)
            {
                return NotFound();
            }

            return theGuarantor;
        }

        // PUT: api/TodoItems/5
      
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheGuarantor(int Id, TheGuarantor theGuarantor)
        {
            if (Id != theGuarantor.Id)
            {
                return BadRequest();
            }

            _context.Entry(theGuarantor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheGuarantorExists(Id))
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

        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<TheGuarantor>> PostTheGuarantor(TheGuarantor theGuarantor)
        {
            _context.TheGuarantors.Add(theGuarantor);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTheGuarantor), new { Id = theGuarantor.Id }, theGuarantor);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheGuarantor(int Id)
        {
            var theGuarantor = await _context.TheGuarantors.FindAsync(Id);
            if (theGuarantor == null)
            {
                return NotFound();
            }

            _context.TheGuarantors.Remove(theGuarantor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TheGuarantorExists(int Id)
        {
            return _context.TheGuarantors.Any(e => e.Id == Id);
        }
    }
}
