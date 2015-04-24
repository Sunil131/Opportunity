using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OpportunityService.Models;

namespace OpportunityService.Controllers
{
    public class NetworksController : ApiController
    {
        private WebApiCorsContext db = new WebApiCorsContext();

        // GET: api/Networks
        public IQueryable<Network> GetNetworks()
        {
            return db.Networks;
        }

        // GET: api/Networks/5
        [ResponseType(typeof(Network))]
        public IHttpActionResult GetNetwork(int id)
        {
            Network network = db.Networks.Find(id);
            if (network == null)
            {
                return NotFound();
            }

            return Ok(network);
        }

        // PUT: api/Networks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNetwork(int id, Network network)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != network.ID)
            {
                return BadRequest();
            }

            db.Entry(network).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NetworkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Networks
        [ResponseType(typeof(Network))]
        public IHttpActionResult PostNetwork(Network network)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Networks.Add(network);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = network.ID }, network);
        }

        // DELETE: api/Networks/5
        [ResponseType(typeof(Network))]
        public IHttpActionResult DeleteNetwork(int id)
        {
            Network network = db.Networks.Find(id);
            if (network == null)
            {
                return NotFound();
            }

            db.Networks.Remove(network);
            db.SaveChanges();

            return Ok(network);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NetworkExists(int id)
        {
            return db.Networks.Count(e => e.ID == id) > 0;
        }
    }
}