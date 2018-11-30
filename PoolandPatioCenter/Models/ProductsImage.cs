using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolandPatioCenter.Models
{
    public class ProductsImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageAlt { get; set; }
        public byte[] ImageData { get; set; }
        public string ContentType { get; set; }
    }
}