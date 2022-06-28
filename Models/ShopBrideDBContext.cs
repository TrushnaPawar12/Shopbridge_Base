using ShopBridgeDemo.Product.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopBridgeDemo.Models
{
    public class ShopBrideDBContext : DbContext
    {
        public ShopBrideDBContext() : base("conn")
        {

        }
        public DbSet<Inventory> inventories { get; set; }
    }
}