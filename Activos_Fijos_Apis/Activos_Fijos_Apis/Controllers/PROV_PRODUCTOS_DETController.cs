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
    public class PROV_PRODUCTOS_DETController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/PROV_PRODUCTOS_DET
        public IQueryable<PROV_PRODUCTOS_DET> GetPROV_PRODUCTOS_DET()
        {
            return db.PROV_PRODUCTOS_DET;
        }

        // GET: api/PROV_PRODUCTOS_DET/5
        [ResponseType(typeof(PROV_PRODUCTOS_DET))]
        public async Task<IHttpActionResult> GetPROV_PRODUCTOS_DET(int id)
        {
            PROV_PRODUCTOS_DET pROV_PRODUCTOS_DET = await db.PROV_PRODUCTOS_DET.FindAsync(id);
            if (pROV_PRODUCTOS_DET == null)
            {
                return NotFound();
            }

            return Ok(pROV_PRODUCTOS_DET);
        }

        // PUT: api/PROV_PRODUCTOS_DET/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPROV_PRODUCTOS_DET(int id, PROV_PRODUCTOS_DET pROV_PRODUCTOS_DET)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pROV_PRODUCTOS_DET.PROV_PRODUCTOS)
            {
                return BadRequest();
            }

            db.Entry(pROV_PRODUCTOS_DET).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PROV_PRODUCTOS_DETExists(id))
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

        // POST: api/PROV_PRODUCTOS_DET
        [ResponseType(typeof(PROV_PRODUCTOS_DET))]
        public async Task<IHttpActionResult> PostPROV_PRODUCTOS_DET(PROV_PRODUCTOS_DET pROV_PRODUCTOS_DET)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PROV_PRODUCTOS_DET.Add(pROV_PRODUCTOS_DET);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PROV_PRODUCTOS_DETExists(pROV_PRODUCTOS_DET.PROV_PRODUCTOS))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pROV_PRODUCTOS_DET.PROV_PRODUCTOS }, pROV_PRODUCTOS_DET);
        }

        // DELETE: api/PROV_PRODUCTOS_DET/5
        [ResponseType(typeof(PROV_PRODUCTOS_DET))]
        public async Task<IHttpActionResult> DeletePROV_PRODUCTOS_DET(int id)
        {
            PROV_PRODUCTOS_DET pROV_PRODUCTOS_DET = await db.PROV_PRODUCTOS_DET.FindAsync(id);
            if (pROV_PRODUCTOS_DET == null)
            {
                return NotFound();
            }

            db.PROV_PRODUCTOS_DET.Remove(pROV_PRODUCTOS_DET);
            await db.SaveChangesAsync();

            return Ok(pROV_PRODUCTOS_DET);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PROV_PRODUCTOS_DETExists(int id)
        {
            return db.PROV_PRODUCTOS_DET.Count(e => e.PROV_PRODUCTOS == id) > 0;
        }
    }
}