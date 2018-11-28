using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Category")]
        public int CategoriesId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("ProductsImage")]
        public int ProductsImagesId { get; set; }
        public ProductsImage ProductsImage { get; set; }
    }
}