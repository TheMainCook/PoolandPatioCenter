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
        public ActionResult Index()
        {
            var product = new Products() { Id = 1, Name = "pool", price = 10 };
            return View(product);
        }
    }
}