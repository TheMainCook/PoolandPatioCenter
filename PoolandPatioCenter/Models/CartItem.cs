using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PoolandPatioCenter.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartItemQuantity { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}