using ShopBridgeDemo.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridgeDemo.Product.Interfaces
{
    interface IInventoryRepository
    {
        Task Add(Inventory inventory);
        Task Update(Inventory inventory);
        Task Delete(int id);
        Task<Inventory> GetInventory(int id);
        Task<IEnumerable<Inventory>> GetInventory();
    }
}
