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
using System.Web.Http.Cors;

namespace Activos_Fijos_Apis.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class DETALLE_VENTAController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/DETALLE_VENTA
        public IQueryable<DETALLE_VENTA> GetDETALLE_VENTA()
        {
            return db.DETALLE_VENTA;
        }

        // GET: api/DETALLE_VENTA/5
        [ResponseType(typeof(DETALLE_VENTA))]
        public async Task<IHttpActionResult> GetDETALLE_VENTA(int id)
        {
            DETALLE_VENTA dETALLE_VENTA = await db.DETALLE_VENTA.FindAsync(id);
            if (dETALLE_VENTA == null)
            {
                return NotFound();
            }

            return Ok(dETALLE_VENTA);
        }

        // PUT: api/DETALLE_VENTA/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDETALLE_VENTA(int id, DETALLE_VENTA dETALLE_VENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dETALLE_VENTA.id_detalle_venta)
            {
                return BadRequest();
            }

            db.Entry(dETALLE_VENTA).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DETALLE_VENTAExists(id))
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

        // POST: api/DETALLE_VENTA
        [ResponseType(typeof(DETALLE_VENTA))]
        public async Task<IHttpActionResult> PostDETALLE_VENTA(DETALLE_VENTA dETALLE_VENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DETALLE_VENTA.Add(dETALLE_VENTA);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = dETALLE_VENTA.id_detalle_venta }, dETALLE_VENTA);
        }

        // DELETE: api/DETALLE_VENTA/5
        [ResponseType(typeof(DETALLE_VENTA))]
        public async Task<IHttpActionResult> DeleteDETALLE_VENTA(int id)
        {
            DETALLE_VENTA dETALLE_VENTA = await db.DETALLE_VENTA.FindAsync(id);
            if (dETALLE_VENTA == null)
            {
                return NotFound();
            }

            db.DETALLE_VENTA.Remove(dETALLE_VENTA);
            await db.SaveChangesAsync();

            return Ok(dETALLE_VENTA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DETALLE_VENTAExists(int id)
        {
            return db.DETALLE_VENTA.Count(e => e.id_detalle_venta == id) > 0;
        }
    }
}