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
    public class StoresController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StoresController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Stores
        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            var stores = await _unitOfWork.Stores.GetAll(includes: q => q.Include(x => x.Game));

            if (stores == null)
            {
                return NotFound();
            }
            return Ok(stores);
        }

        // GET: api/Stores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStore(int id)
        {
            var store = await _unitOfWork.Stores.Get(q => q.Id == id);

            if (store == null)
            {
                return NotFound();
            }
            return Ok(store);
        }

        // PUT: api/Stores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStore(int id, Store store)
        {
            if (id != store.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Stores.Update(store);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await StoreExists(id))
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

        // POST: api/Stores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Store>> PostStore(Store store)
        {
            await _unitOfWork.Stores.Insert(store);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStore", new { id = store.Id }, store);
        }

        // DELETE: api/Stores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStore(int id)
        {
            var store = await _unitOfWork.Stores.Get(q => q.Id == id);
            if (store == null)
            {
                return NotFound();
            }

            await _unitOfWork.Stores.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> StoreExists(int id)
        {
            var store = await _unitOfWork.Stores.Get(q => q.Id == id);
            return store != null;
        }
    }
}
