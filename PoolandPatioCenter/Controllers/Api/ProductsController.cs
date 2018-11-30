using PoolandPatioCenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace PoolandPatioCenter.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/Products
        [HttpGet]
        public IEnumerable<Products> GetProducts()
        {
            
            return _context.Products.Include(p => p.ProductsImage).Include(p => p.Category).ToList();
        } 

        // POST /api/Products
        [HttpPost]
        public IHttpActionResult CreateProducts(Products products)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Products.Add(products);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + products.Id), products);
        }



        // PUT /api/Products/1
        [HttpPut]
        public IHttpActionResult UpdateProducts(int id, Products products)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var ProductInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (ProductInDb == null)
            {
                return NotFound();
            }

            ProductInDb.Name = products.Name;
            ProductInDb.Price = products.Price;
            ProductInDb.Description = products.Description;
            ProductInDb.CategoriesId = products.CategoriesId;
            ProductInDb.ProductsImagesId = products.ProductsImagesId;
            ProductInDb.Quantity = products.Quantity;

            _context.SaveChanges();

            return Ok();
        }

       

        // DELETE /api/Product/1
        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            var ProductInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (ProductInDb == null)
            {
                return NotFound();
            }

            _context.Products.Remove(ProductInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
