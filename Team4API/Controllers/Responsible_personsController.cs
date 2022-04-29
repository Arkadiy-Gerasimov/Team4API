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
    public class Responsible_personsController : ApiController
    {
        private Inventory_ItemsEntities db = new Inventory_ItemsEntities();

        // GET: api/Responsible_persons
        [ResponseType(typeof(List<Product>))]
        public IHttpActionResult GetResponsible_persons()
        {
            return Ok(db.Responsible_persons.ToList().ConvertAll(p => new ResponsiblePersModel(p)));
            //return db.Responsible_persons;
        }

        [Route("api/GetCompanyANDDivision")]
        public IHttpActionResult GetCompanyANDDivision(int PId, int PId2)
        {
            var f = db.Responsible_persons.ToList().Where(x => x.Company.ID_company == PId && x.Division.ID_division == PId2).ToList();
            return Ok(f);
        }

        // GET: api/Responsible_persons/5
        [ResponseType(typeof(Responsible_persons))]
        public IHttpActionResult GetResponsible_persons(int id)
        {
            Responsible_persons responsible_persons = db.Responsible_persons.Find(id);
            if (responsible_persons == null)
            {
                return NotFound();
            }

            return Ok(responsible_persons);
        }

        // PUT: api/Responsible_persons/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResponsible_persons(int id, Responsible_persons responsible_persons)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != responsible_persons.ID_responsible_persons)
            {
                return BadRequest();
            }

            db.Entry(responsible_persons).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Responsible_personsExists(id))
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

        // POST: api/Responsible_persons
        [ResponseType(typeof(Responsible_persons))]
        public IHttpActionResult PostResponsible_persons(Responsible_persons responsible_persons)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Responsible_persons.Add(responsible_persons);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = responsible_persons.ID_responsible_persons }, responsible_persons);
        }

        // DELETE: api/Responsible_persons/5
        [ResponseType(typeof(Responsible_persons))]
        public IHttpActionResult DeleteResponsible_persons(int id)
        {
            Responsible_persons responsible_persons = db.Responsible_persons.Find(id);
            if (responsible_persons == null)
            {
                return NotFound();
            }

            db.Responsible_persons.Remove(responsible_persons);
            db.SaveChanges();

            return Ok(responsible_persons);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Responsible_personsExists(int id)
        {
            return db.Responsible_persons.Count(e => e.ID_responsible_persons == id) > 0;
        }
    }
}