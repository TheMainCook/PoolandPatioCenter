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
        public IEnumerable<CartItem> GetCartItem(string id)
        {
            return _context.CartItem.Include(r => r.ProductId).Where(r => r.UserId == id).ToList();
        }
        
        // POST /api/CartItem
        [HttpPost]
        public CartItem CreateCartItems(CartItem CartItem)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.CartItem.Add(CartItem);
            _context.SaveChanges();

            return CartItem;
        }



        // PUT /api/CartItem/1
        [HttpPut]
        public void UpdateCartItems(int id, CartItem CartItem)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var CartItemInDb = _context.CartItem.SingleOrDefault(p => p.Id == id);

            if (CartItemInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            CartItemInDb.UserId = CartItem.UserId;
            CartItemInDb.ProductId = CartItem.ProductId;
            CartItemInDb.CartItemQuantity = CartItem.CartItemQuantity;
            


            _context.SaveChanges();

        }




        // DELETE /api/CartItem/1
        public void DeleteCartItem(int id)
        {
            var CartItemInDb = _context.CartItem.SingleOrDefault(p => p.Id == id);

            if (CartItemInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.CartItem.Remove(CartItemInDb);
            _context.SaveChanges();
        }

    }
}
