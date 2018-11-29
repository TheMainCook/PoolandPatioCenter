using PoolandPatioCenter.Models;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Products> GetProducts()
        {
            return _context.Products.ToList();
        } 

        // POST /api/Products
        [HttpPost]
        public Products CreateProducts(Products products)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.Products.Add(products);
            _context.SaveChanges();

            return products;
        }



        // PUT /api/Products/1
        [HttpPut]
        public void UpdateProducts(int id, Products products)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var ProductInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (ProductInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            ProductInDb.Name = products.Name;
            ProductInDb.Price = products.Price;
            ProductInDb.Description = products.Description;
            ProductInDb.CategoriesId = products.CategoriesId;
            ProductInDb.ProductsImagesId = products.ProductsImagesId;
            ProductInDb.Quantity = products.Quantity;

            _context.SaveChanges();

        }

        // PUT /api/Products/1
        [HttpPut]
        public void minusProducts(int id, Products products)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var ProductInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (ProductInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            ProductInDb.Name = products.Name;
            ProductInDb.Price = products.Price;
            ProductInDb.Description = products.Description;
            ProductInDb.CategoriesId = products.CategoriesId;
            ProductInDb.ProductsImagesId = products.ProductsImagesId;
            ProductInDb.Quantity = products.Quantity -1;

            _context.SaveChanges();

        }


        // DELETE /api/Product/1
        public void DeleteProduct(int id)
        {
            var ProductInDb = _context.Products.SingleOrDefault(p => p.Id == id);

            if (ProductInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Products.Remove(ProductInDb);
            _context.SaveChanges();
        }

    }
}
