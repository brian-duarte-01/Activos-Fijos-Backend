using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Activos_Fijos_Apis.Models;

namespace Activos_Fijos_Apis.Controllers
{
    public class ACT_ALQUILERController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ACT_ALQUILER
        public IQueryable<ACT_ALQUILER> GetACT_ALQUILER()
        {
            return db.ACT_ALQUILER;
        }

        // GET: api/ACT_ALQUILER/5
        [ResponseType(typeof(ACT_ALQUILER))]
        public async Task<IHttpActionResult> GetACT_ALQUILER(int id)
        {
            ACT_ALQUILER aCT_ALQUILER = await db.ACT_ALQUILER.FindAsync(id);
            if (aCT_ALQUILER == null)
            {
                return NotFound();
            }

            return Ok(aCT_ALQUILER);
        }

        // PUT: api/ACT_ALQUILER/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutACT_ALQUILER(int id, ACT_ALQUILER aCT_ALQUILER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aCT_ALQUILER.ID_CONTRATO)
            {
                return BadRequest();
            }

            db.Entry(aCT_ALQUILER).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACT_ALQUILERExists(id))
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

        // POST: api/ACT_ALQUILER
        [ResponseType(typeof(ACT_ALQUILER))]
        public async Task<IHttpActionResult> PostACT_ALQUILER(ACT_ALQUILER aCT_ALQUILER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACT_ALQUILER.Add(aCT_ALQUILER);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aCT_ALQUILER.ID_CONTRATO }, aCT_ALQUILER);
        }

        // DELETE: api/ACT_ALQUILER/5
        [ResponseType(typeof(ACT_ALQUILER))]
        public async Task<IHttpActionResult> DeleteACT_ALQUILER(int id)
        {
            ACT_ALQUILER aCT_ALQUILER = await db.ACT_ALQUILER.FindAsync(id);
            if (aCT_ALQUILER == null)
            {
                return NotFound();
            }

            db.ACT_ALQUILER.Remove(aCT_ALQUILER);
            await db.SaveChangesAsync();

            return Ok(aCT_ALQUILER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACT_ALQUILERExists(int id)
        {
            return db.ACT_ALQUILER.Count(e => e.ID_CONTRATO == id) > 0;
        }
    }
}