using ShopBridgeDemo.Product.Interfaces;
using ShopBridgeDemo.Product.Models;
using ShopBridgeDemo.Product.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ShopBridgeDemo.Product.Controllers
{
    public class InventoryController : ApiController
    {
        private readonly IInventoryRepository _iInventoryRepository = new InventoryRepository();

        [HttpGet]
        [Route("api/Inventory/Get")]
        public async Task<IEnumerable<Inventory>> Get()
        {
            return await _iInventoryRepository.GetInventory();
        }

        [HttpPost]
        [Route("api/Inventory/Create")]
        public async Task CreateAsync([FromBody] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                await _iInventoryRepository.Add(inventory);
            }
        }

        [HttpGet]
        [Route("api/Inventory/Details/{id}")]
        public async Task<Inventory> Details(int id)
        {
            var result = await _iInventoryRepository.GetInventory(id);
            return result;
        }

        [HttpPut]
        [Route("api/Employees/Edit")]
        public async Task EditAsync([FromBody] Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                await _iInventoryRepository.Update(inventory);
            }
        }

        [HttpDelete]
        [Route("api/Inventory/Delete/{id}")]
        public async Task DeleteConfirmedAsync(int id)
        {
            await _iInventoryRepository.Delete(id);
        }
    }
}