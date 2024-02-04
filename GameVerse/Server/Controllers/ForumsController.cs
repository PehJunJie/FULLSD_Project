using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameVerse.Server.Data;
using GameVerse.Shared.Domain;
using GameVerse.Server.IRepository;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GameVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;

        //public ForumsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //Refractored
        private readonly IUnitOfWork _unitOfWork;
        public ForumsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Forums
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Forum>>> GetForums()
        //{
        //  if (_context.Forums == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Forums.ToListAsync();
        //}

        //Refractored
        public async Task<IActionResult> GetForums()
        {
            var forums = await _unitOfWork.Forums.GetAll(includes: q => q.Include(x => x.Consumer));
            return Ok(forums);
        }

        // GET: api/Forums/5
        [HttpGet("{id}")]

        //public async Task<ActionResult<Forum>> GetForum(int id)
        //Refractored
        public async Task<IActionResult> GetForum(int id)
        {
            //var forum = await _context.Forums.FindAsync(id);
            var forum = await _unitOfWork.Forums.Get(q=>q.Id == id);

            if (forum == null)
            {
                return NotFound();
            }

            //return forum;
            return Ok(forum);
        }

        // PUT: api/Forums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForum(int id, Forum forum)
        {
            if (id != forum.Id)
            {
                return BadRequest();
            }
            //Refractored
            //_context.Entry(forum).State = EntityState.Modified;
            _unitOfWork.Forums.Update(forum);

            try
            {
                //Refractored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refractored
                //if (!ForumExists(id))
                if (!await ForumExists(id))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

            return NoContent();
        }

        // POST: api/Forums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Forum>> PostForum(Forum forum)
        {
            //Refractored
            //if (_context.Forums == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Forums'  is null.");
            //}
            //  _context.Forums.Add(forum);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.Forums.Insert(forum);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetForum", new { id = forum.Id }, forum);
        }

        // DELETE: api/Forums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForum(int id)
        {
            //Refractored
            //if (_context.Forums == null)
            //{
            //    return NotFound();
            //}
            //var forum = await _context.Forums.FindAsync(id);
            var forum = await _unitOfWork.Forums.Get(q => q.Id == id);
            if (forum == null)
            {
                return NotFound();
            }
            //Refractored
            //_context.Forums.Remove(forum);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Forums.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        //Refractored
        // private bool ForumExists(int id)
        private async Task<bool> ForumExists(int id)
        {
            //return (_context.Forums?.Any(e => e.Id == id)).GetValueOrDefault();
            var forum = await _unitOfWork.Forums.Get(q => q.Id == id);
            return forum != null;
        }
    }
}
