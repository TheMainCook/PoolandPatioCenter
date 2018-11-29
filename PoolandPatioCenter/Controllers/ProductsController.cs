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

        #region DropDownVeiws
        public ViewResult Spas()
        {
            return View();
        }

        public ViewResult Grills()
        {
            return View();
        }

        public ViewResult Patio()
        {
            return View();
        }

        public ViewResult Entertainment()
        {
            return View();
        }

        public ViewResult Furniture()
        {
            return View();
        }

        public ViewResult PoolChemicals()
        {
            return View();
        }
        #endregion

    }
}