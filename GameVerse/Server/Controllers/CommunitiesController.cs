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

namespace GameVerse.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitiesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommunitiesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Communitys
        [HttpGet]
        public async Task<IActionResult> GetCommunitys()
        {
            var communitys = await _unitOfWork.Communities.GetAll();

            if (communitys == null)
            {
                return NotFound();
            }
            return Ok(communitys);
        }

        // GET: api/Communitys/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommunity(int id)
        {
            var community = await _unitOfWork.Communities.Get(q => q.Id == id);

            if (community == null)
            {
                return NotFound();
            }
            return Ok(community);
        }

        // PUT: api/Communitys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommunity(int id, Community community)
        {
            if (id != community.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Communities.Update(community);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CommunityExists(id))
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

        // POST: api/Communitys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Community>> PostCommunity(Community community)
        {
            await _unitOfWork.Communities.Insert(community);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCommunity", new { id = community.Id }, community);
        }

        // DELETE: api/Communitys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommunity(int id)
        {
            var community = await _unitOfWork.Communities.Get(q => q.Id == id);
            if (community == null)
            {
                return NotFound();
            }

            await _unitOfWork.Communities.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CommunityExists(int id)
        {
            var community = await _unitOfWork.Communities.Get(q => q.Id == id);
            return community != null;
        }
    }
}
