using PoolandPatioCenter.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoolandPatioCenter.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;

        public CartController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Cart
        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            var cartitem = _context.CartItem.Include(c => c.Products).ToList().Where(c => c.UserId == id);
            return View(cartitem);
        }
    }
}