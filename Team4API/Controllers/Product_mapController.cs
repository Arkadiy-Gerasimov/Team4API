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
using Team4API;
using Team4API.Models;
namespace Team4API.Controllers
{
    public class Product_mapController : ApiController
    {
        private Inventory_ItemsEntities db = new Inventory_ItemsEntities();

        // GET: api/Product_map
        [ResponseType(typeof(List <Product_map>))]
        public IHttpActionResult GetProduct_map()
        {
            return Ok(db.Product_map.ToList().ConvertAll(p => new PP(p)));
            //return db.Product_map;
        }
        [Route("api/GetStatusID")]
        public IHttpActionResult GetStatusID(int PId)
        {
            var f = db.Product_map.ToList().Where(x => x.Status.ID_status == PId).ToList();
            return Ok(f);
        }

        // GET: api/Product_map/5
        [ResponseType(typeof(Product_map))]
        public IHttpActionResult GetProduct_map(long id)
        {
            Product_map product_map = db.Product_map.Find(id);
            if (product_map == null)
            {
                return NotFound();
            }

            return Ok(product_map);
        }

        // PUT: api/Product_map/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct_map(long id, Product_map product_map)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product_map.inventory_number)
            {
                return BadRequest();
            }

            db.Entry(product_map).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_mapExists(id))
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

        // POST: api/Product_map
        [ResponseType(typeof(Product_map))]
        public IHttpActionResult PostProduct_map(Product_map product_map)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Product_map.Add(product_map);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Product_mapExists(product_map.inventory_number))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = product_map.inventory_number }, product_map);
        }

        // DELETE: api/Product_map/5
        [ResponseType(typeof(Product_map))]
        public IHttpActionResult DeleteProduct_map(long id)
        {
            Product_map product_map = db.Product_map.Find(id);
            if (product_map == null)
            {
                return NotFound();
            }

            db.Product_map.Remove(product_map);
            db.SaveChanges();

            return Ok(product_map);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Product_mapExists(long id)
        {
            return db.Product_map.Count(e => e.inventory_number == id) > 0;
        }
    }
}