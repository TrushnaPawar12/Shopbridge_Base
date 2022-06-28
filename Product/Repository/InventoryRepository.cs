using ShopBridgeDemo.Models;
using ShopBridgeDemo.Product.Interfaces;
using ShopBridgeDemo.Product.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ShopBridgeDemo.Product.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ShopBrideDBContext db = new ShopBrideDBContext();
        public async Task Add(Inventory inventory)
        {           
            db.inventories.Add(inventory);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<Inventory> GetInventory(int id)
        {
            try
            {
                Inventory inventory = await db.inventories.FindAsync(id);
                if (inventory == null)
                {
                    return null;
                }
                return inventory;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Inventory>> GetInventory()
        {
            try
            {
                var inventories = await db.inventories.ToListAsync();
                return inventories.AsQueryable();
            }
            catch
            {
                throw;
            }
        }
        public async Task Update(Inventory inventory)
        {
            try
            {
                db.Entry(inventory).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task Delete(int id)
        {
            try
            {
                Inventory inventory = await db.inventories.FindAsync(id);
                db.inventories.Remove(inventory);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        private bool EmployeeExists(int id)
        {
            return db.inventories.Count(i => i.Id == id) > 0;
        }

    }
}
