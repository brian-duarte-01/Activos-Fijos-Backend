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
    public class DET_ACTIVOController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/DET_ACTIVO
        public IQueryable<DET_ACTIVO> GetDET_ACTIVO()
        {
            return db.DET_ACTIVO;
        }

        // GET: api/DET_ACTIVO/5
        [ResponseType(typeof(DET_ACTIVO))]
        public async Task<IHttpActionResult> GetDET_ACTIVO(int id)
        {
            DET_ACTIVO dET_ACTIVO = await db.DET_ACTIVO.FindAsync(id);
            if (dET_ACTIVO == null)
            {
                return NotFound();
            }

            return Ok(dET_ACTIVO);
        }

        // PUT: api/DET_ACTIVO/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDET_ACTIVO(int id, DET_ACTIVO dET_ACTIVO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dET_ACTIVO.ID_DETALLE)
            {
                return BadRequest();
            }

            db.Entry(dET_ACTIVO).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DET_ACTIVOExists(id))
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

        // POST: api/DET_ACTIVO
        [ResponseType(typeof(DET_ACTIVO))]
        public async Task<IHttpActionResult> PostDET_ACTIVO(DET_ACTIVO dET_ACTIVO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DET_ACTIVO.Add(dET_ACTIVO);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DET_ACTIVOExists(dET_ACTIVO.ID_DETALLE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = dET_ACTIVO.ID_DETALLE }, dET_ACTIVO);
        }

        // DELETE: api/DET_ACTIVO/5
        [ResponseType(typeof(DET_ACTIVO))]
        public async Task<IHttpActionResult> DeleteDET_ACTIVO(int id)
        {
            DET_ACTIVO dET_ACTIVO = await db.DET_ACTIVO.FindAsync(id);
            if (dET_ACTIVO == null)
            {
                return NotFound();
            }

            db.DET_ACTIVO.Remove(dET_ACTIVO);
            await db.SaveChangesAsync();

            return Ok(dET_ACTIVO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DET_ACTIVOExists(int id)
        {
            return db.DET_ACTIVO.Count(e => e.ID_DETALLE == id) > 0;
        }
    }
}