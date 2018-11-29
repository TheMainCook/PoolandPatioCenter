using PoolandPatioCenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoolandPatioCenter.Controllers.Api
{
    public class CartItemsController : ApiController
    {
        private ApplicationDbContext _context;

        public CartItemsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/CartItems/i
        [HttpGet]
        public IEnumerable<CartItem> GetCartItem(string id)
        {
            return _context.CartItem.Include(r => r.ProductId).Where(r => r.UserId == id).ToList();
        }




        // POST /api/CartItem
        [HttpPost]
        public IHttpActionResult CreateCartItems(CartItem CartItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.CartItem.Add(CartItem);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri+"/"+CartItem.Id),CartItem);
        }



        // PUT /api/CartItem/1
        [HttpPut]
        public IHttpActionResult UpdateCartItems(int id, CartItem CartItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var CartItemInDb = _context.CartItem.SingleOrDefault(p => p.Id == id);

            if (CartItemInDb == null)
            {
                return NotFound();
            }

            CartItemInDb.UserId = CartItem.UserId;
            CartItemInDb.ProductId = CartItem.ProductId;
            CartItemInDb.CartItemQuantity = CartItem.CartItemQuantity;
            


            _context.SaveChanges();

            return Ok();
        }




        // DELETE /api/CartItem/1
        [HttpDelete]
        public IHttpActionResult DeleteCartItem(int id)
        {
            var CartItemInDb = _context.CartItem.SingleOrDefault(p => p.Id == id);

            if (CartItemInDb == null)
            {
                return NotFound();
            }

            _context.CartItem.Remove(CartItemInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
