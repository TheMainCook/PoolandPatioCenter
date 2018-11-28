using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PoolandPatioCenter.Models
{
    public class LastBought
    {
        public int Id { get; set; }
        public int LastBoughtQuantity { get; set; }
        public DateTime LastBoughtDate { get; set; }
        [ForeignKey("Products")]
        public int ProductsId { get; set; }
        public Products Products { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}