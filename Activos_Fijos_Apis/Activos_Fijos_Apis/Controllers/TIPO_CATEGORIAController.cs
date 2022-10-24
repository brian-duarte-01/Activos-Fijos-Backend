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
    public class TIPO_CATEGORIAController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/TIPO_CATEGORIA
        public IQueryable<TIPO_CATEGORIA> GetTIPO_CATEGORIA()
        {
            return db.TIPO_CATEGORIA;
        }

        // GET: api/TIPO_CATEGORIA/5
        [ResponseType(typeof(TIPO_CATEGORIA))]
        public async Task<IHttpActionResult> GetTIPO_CATEGORIA(int id)
        {
            TIPO_CATEGORIA tIPO_CATEGORIA = await db.TIPO_CATEGORIA.FindAsync(id);
            if (tIPO_CATEGORIA == null)
            {
                return NotFound();
            }

            return Ok(tIPO_CATEGORIA);
        }

        // PUT: api/TIPO_CATEGORIA/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTIPO_CATEGORIA(int id, TIPO_CATEGORIA tIPO_CATEGORIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tIPO_CATEGORIA.ID_TIPO_CATEGORIA)
            {
                return BadRequest();
            }

            db.Entry(tIPO_CATEGORIA).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TIPO_CATEGORIAExists(id))
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

        // POST: api/TIPO_CATEGORIA
        [ResponseType(typeof(TIPO_CATEGORIA))]
        public async Task<IHttpActionResult> PostTIPO_CATEGORIA(TIPO_CATEGORIA tIPO_CATEGORIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TIPO_CATEGORIA.Add(tIPO_CATEGORIA);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tIPO_CATEGORIA.ID_TIPO_CATEGORIA }, tIPO_CATEGORIA);
        }

        // DELETE: api/TIPO_CATEGORIA/5
        [ResponseType(typeof(TIPO_CATEGORIA))]
        public async Task<IHttpActionResult> DeleteTIPO_CATEGORIA(int id)
        {
            TIPO_CATEGORIA tIPO_CATEGORIA = await db.TIPO_CATEGORIA.FindAsync(id);
            if (tIPO_CATEGORIA == null)
            {
                return NotFound();
            }

            db.TIPO_CATEGORIA.Remove(tIPO_CATEGORIA);
            await db.SaveChangesAsync();

            return Ok(tIPO_CATEGORIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TIPO_CATEGORIAExists(int id)
        {
            return db.TIPO_CATEGORIA.Count(e => e.ID_TIPO_CATEGORIA == id) > 0;
        }
    }
}