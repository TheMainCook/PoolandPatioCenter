using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoolandPatioCenter.Models;
using System.IO;

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
            //return View(products);

            if (User.IsInRole("CanManageProducts"))
            {
                return View("Index", products);

            }
            else if (User.IsInRole("CanPurchaseProducts"))
            {
                return View("IndexCustomerView", products);
            }
            else
            {
                return View("IndexReadOnly", products);
            }
        }

        public ActionResult GetProductsImageByProductId(int id)
        {
            var products = _context.Products.Include(m => m.ProductsImage).SingleOrDefault(m => m.Id == id);
            if (products != null && products.ProductsImage != null)
            {
                return File(products.ProductsImage.ImageData, products.ProductsImage.ContentType);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        
        public ViewResult ProductsForm()
        {
            return View();
        }

        public ActionResult Save(Products products, HttpPostedFileBase productImageUpload)//handle the form data AND the image upload
        {
            if (!ModelState.IsValid)
            {
              
                return View("Index");
            }

            if (productImageUpload != null && productImageUpload.ContentLength > 0)//check to see if we actually uploaded a movie image
            {
                var image = new ProductsImage
                {
                    ImageName = Path.GetFileName(productImageUpload.FileName),
                    ContentType = productImageUpload.ContentType
                };
                using (var reader = new System.IO.BinaryReader(productImageUpload.InputStream))
                {
                    image.ImageData = reader.ReadBytes(productImageUpload.ContentLength);
                }
                _context.ProductsImage.Add(image); //save the new image to the DB
                _context.SaveChanges();

                products.ProductsImage = image;
                products.ProductsImagesId = image.Id;
            }

            if (products.Id == 0)//this is a new movie
            {
                _context.Products.Add(products);
            }
            else//we are updating an existing movie
            {
                //pull the existing movie out of the DB and include the movie's image
                var productInDb = _context.Products.Include(p => p.ProductsImagesId).Single(p => p.Id == products.Id);
                productInDb.Name = products.Name;
                productInDb.Price = products.Price;
                productInDb.Description = products.Description;
                productInDb.CategoriesId = products.CategoriesId;
                productInDb.Quantity = products.Quantity;
                if (products.ProductsImagesId != null && products.ProductsImagesId != 0)
                {
                    //delete the previous image in the DB first (if one exists)
                    if (productInDb.ProductsImage != null)
                    {
                        _context.ProductsImage.Remove(productInDb.ProductsImage);
                        _context.SaveChanges();
                    }
                    //assign new movie image to existing movie that we pulled out of the DB
                    productInDb.ProductsImage = products.ProductsImage;
                    productInDb.ProductsImagesId = products.ProductsImagesId;
                }
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }



        #region CategoriesDropDownVeiws

        public ViewResult Entertainment()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("EntertainmentCustomerView", products);
            else
                return View("EntertainmentReadOnly", products);
        }

        public ViewResult Spas()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("SpasCustomerView", products);
            else
                return View("SpasReadOnly", products);
        }

        public ViewResult Grills()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("GrillsCustomerView", products);
            else
                return View("GrillsReadOnly", products);
        }

        public ViewResult Patio()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("PatioCustomerView", products);
            else
                return View("PatioReadOnly", products);
        }

        public ViewResult Furniture()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("FurnitureCustomerView", products);
            else
                return View("FurnitureReadOnly", products);
        }

        public ViewResult PoolChemicals()
        {
            var products = _context.Products.ToList();
            //return View(products);

            if (User.IsInRole("CanPurchaseProducts"))
                return View("PoolChemicalsCustomerView", products);
            else
                return View("PoolChemicalsReadOnly", products);
        }
        #endregion

    }
}