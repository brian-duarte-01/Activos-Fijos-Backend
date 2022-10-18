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
    public class ACT_ESTADOController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ACT_ESTADO
        public IQueryable<ACT_ESTADO> GetACT_ESTADO()
        {
            return db.ACT_ESTADO;
        }

        // GET: api/ACT_ESTADO/5
        [ResponseType(typeof(ACT_ESTADO))]
        public async Task<IHttpActionResult> GetACT_ESTADO(int id)
        {
            ACT_ESTADO aCT_ESTADO = await db.ACT_ESTADO.FindAsync(id);
            if (aCT_ESTADO == null)
            {
                return NotFound();
            }

            return Ok(aCT_ESTADO);
        }

        // PUT: api/ACT_ESTADO/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutACT_ESTADO(int id, ACT_ESTADO aCT_ESTADO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aCT_ESTADO.id_estado)
            {
                return BadRequest();
            }

            db.Entry(aCT_ESTADO).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACT_ESTADOExists(id))
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

        // POST: api/ACT_ESTADO
        [ResponseType(typeof(ACT_ESTADO))]
        public async Task<IHttpActionResult> PostACT_ESTADO(ACT_ESTADO aCT_ESTADO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACT_ESTADO.Add(aCT_ESTADO);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aCT_ESTADO.id_estado }, aCT_ESTADO);
        }

        // DELETE: api/ACT_ESTADO/5
        [ResponseType(typeof(ACT_ESTADO))]
        public async Task<IHttpActionResult> DeleteACT_ESTADO(int id)
        {
            ACT_ESTADO aCT_ESTADO = await db.ACT_ESTADO.FindAsync(id);
            if (aCT_ESTADO == null)
            {
                return NotFound();
            }

            db.ACT_ESTADO.Remove(aCT_ESTADO);
            await db.SaveChangesAsync();

            return Ok(aCT_ESTADO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACT_ESTADOExists(int id)
        {
            return db.ACT_ESTADO.Count(e => e.id_estado == id) > 0;
        }
    }
}