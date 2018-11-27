using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolandPatioCenter.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Products> ProductsId { get; set; }

    }
}