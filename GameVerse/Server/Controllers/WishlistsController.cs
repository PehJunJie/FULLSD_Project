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
    public class WishlistsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WishlistsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Wishlists
        [HttpGet]
        public async Task<IActionResult> GetWishlists()
        {
            var wishlists = await _unitOfWork.Wishlists.GetAll();

            if (wishlists == null)
            {
                return NotFound();
            }
            return Ok(wishlists);
        }

        // GET: api/Wishlists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWishlist(int id)
        {
            var wishlist = await _unitOfWork.Wishlists.Get(q => q.Id == id);

            if (wishlist == null)
            {
                return NotFound();
            }
            return Ok(wishlist);
        }

        // PUT: api/Wishlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWishlist(int id, Wishlist wishlist)
        {
            if (id != wishlist.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Wishlists.Update(wishlist);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WishlistExists(id))
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

        // POST: api/Wishlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Wishlist>> PostWishlist(Wishlist wishlist)
        {
            await _unitOfWork.Wishlists.Insert(wishlist);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWishlist", new { id = wishlist.Id }, wishlist);
        }

        // DELETE: api/Wishlists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWishlist(int id)
        {
            var wishlist = await _unitOfWork.Wishlists.Get(q => q.Id == id);
            if (wishlist == null)
            {
                return NotFound();
            }

            await _unitOfWork.Wishlists.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WishlistExists(int id)
        {
            var wishlist = await _unitOfWork.Wishlists.Get(q => q.Id == id);
            return wishlist != null;
        }
    }
}
