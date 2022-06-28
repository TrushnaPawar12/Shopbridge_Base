using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBridgeDemo.Product.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

    }
}