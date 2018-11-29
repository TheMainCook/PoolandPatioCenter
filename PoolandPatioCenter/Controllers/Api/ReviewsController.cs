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
    public class ReviewsController : ApiController
    {
        private ApplicationDbContext _context;

        public ReviewsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/Review/i
        [HttpGet]
        public IEnumerable<Review> GetReview(int id)
        {
            return _context.Review.Where(r => r.ProductsId == id).ToList();
        }




        // POST /api/Review
        [HttpPost]
        public IHttpActionResult CreateReviews(Review Review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Review.Add(Review);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri+"/"+Review.Id), Review);
        }



        // PUT /api/Review/1
        [HttpPut]
        public IHttpActionResult UpdateReviews(int id, Review Review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var ReviewInDb = _context.Review.SingleOrDefault(p => p.Id == id);

            if (ReviewInDb == null)
            {
                return NotFound();
            }

            ReviewInDb.Reviewstring = Review.Reviewstring;
            ReviewInDb.ProductsId = Review.ProductsId;
            ReviewInDb.UserId = Review.UserId;
            ReviewInDb.ReviewDate = Review.ReviewDate;
           

            _context.SaveChanges();

            return Ok();
        }




        // DELETE /api/Review/1
        [HttpDelete]
        public IHttpActionResult DeleteReview(int id)
        {
            var ReviewInDb = _context.Review.SingleOrDefault(p => p.Id == id);

            if (ReviewInDb == null)
            {
                return NotFound();
            }

            _context.Review.Remove(ReviewInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
