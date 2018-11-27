using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolandPatioCenter.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public List<string> Reviews { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}