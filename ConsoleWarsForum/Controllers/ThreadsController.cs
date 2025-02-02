using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConsoleWarsForum.Models;

namespace ConsoleWarsForum.Controllers
{
    [Route("api/[controller]")]   
    [ApiController]
    public class ThreadsController : ControllerBase
    {
        private readonly ConsoleWarsForumContext _context;

        public ThreadsController(ConsoleWarsForumContext context)
        {
            _context = context;
        }

        // GET: api/Threads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Thread>>> GetThreads()
        {
            return await _context.Threads.ToListAsync();
        }

        // GET: api/Threads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Thread>> GetThread(int id)
        {
            var thread = await _context.Threads.FindAsync(id);  //findasync is able to identify the primary key.  it knows not to use postsid because that is a foreign key

            if (thread == null)
            {
                return NotFound();
            }

            return thread;
        }

        // PUT: api/Threads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThread(int id, Thread thread)
        {
            if (id != thread.ThreadId)
            {
                return BadRequest();
            }

            _context.Entry(thread).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThreadExists(id))
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

        // POST: api/Threads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Thread>> PostThread(Thread thread)
        {
            thread.DateAndTimeStamp = DateTime.Now;
            _context.Threads.Add(thread);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostThread", new { id = thread.ThreadId }, thread);
        }

        // DELETE: api/Threads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThread(int id)
        {
            var thread = await _context.Threads.FindAsync(id);
            if (thread == null)
            {
                return NotFound();
            }

            _context.Threads.Remove(thread);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThreadExists(int id)
        {
            return _context.Threads.Any(e => e.ThreadId == id);
        }
    }
}
