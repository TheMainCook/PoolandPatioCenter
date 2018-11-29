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

        // GET /api/LastBought/i
        [HttpGet]
        public IEnumerable<LastBought> GetAllLastBought()
        {
            return _context.LastBought.ToList();
        }

        // GET /api/LastBought/i
        public IEnumerable<LastBought> GetLastBought(int id)
        {
            return _context.LastBought.Include(r => r.UserId).ToList();
        }




        // POST /api/LastBought
        [HttpPost]
        public LastBought CreateLastBought(LastBought LastBought)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.LastBought.Add(LastBought);
            _context.SaveChanges();

            return LastBought;
        }








        // DELETE /api/LastBought/1
        public void DeleteLastBought(int id)
        {
            var LastBoughtInDb = _context.LastBought.SingleOrDefault(p => p.Id == id);

            if (LastBoughtInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.LastBought.Remove(LastBoughtInDb);
            _context.SaveChanges();
        }

    }
}
