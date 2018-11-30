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
    public class LastBoughtsController : ApiController
    {
        private ApplicationDbContext _context;

        public LastBoughtsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/LastBought
        [HttpGet]
        public IEnumerable<LastBought> GetAllLastBought()
        {
            return _context.LastBought.ToList();
        }

        // GET /api/LastBought/i
        [HttpGet]
        public IEnumerable<LastBought> GetLastBought(string id)
        {
            return _context.LastBought.Where(l => l.UserId == id).ToList();
        }




        // POST /api/LastBought
        [HttpPost]
        public IHttpActionResult CreateLastBought(LastBought LastBought)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.LastBought.Add(LastBought);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri +"/" + LastBought.Id),LastBought);
        }








        // DELETE /api/LastBought/1
        [HttpDelete]
        public IHttpActionResult DeleteLastBought(int id)
        {
            var LastBoughtInDb = _context.LastBought.SingleOrDefault(p => p.Id == id);

            if (LastBoughtInDb == null)
            {
                return NotFound();
            }

            _context.LastBought.Remove(LastBoughtInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
