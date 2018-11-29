using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoolandPatioCenter.Models;
namespace PoolandPatioCenter.Controllers
{
    [AllowAnonymous]
    public class ProductsController : Controller
    {
        // GET: Products
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        //protected override void Dispose(bool disposing)

        //public ActionResult Index()
        //{

        //}

        public ActionResult Index()
        {
            var product = new Products() { };
            return View(product);
        }
    }
}