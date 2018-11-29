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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ViewResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        #region CategoriesDropDownVeiws

        public ViewResult Entertainment()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ViewResult Spas()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ViewResult Grills()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ViewResult Patio()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ViewResult Furniture()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public ViewResult PoolChemicals()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        #endregion

    }
}