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
    public class ACT_CATEGORIAController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ACT_CATEGORIA
        public IQueryable<ACT_CATEGORIA> GetACT_CATEGORIA()
        {
            return db.ACT_CATEGORIA;
        }

        // GET: api/ACT_CATEGORIA/5
        [ResponseType(typeof(ACT_CATEGORIA))]
        public async Task<IHttpActionResult> GetACT_CATEGORIA(int id)
        {
            ACT_CATEGORIA aCT_CATEGORIA = await db.ACT_CATEGORIA.FindAsync(id);
            if (aCT_CATEGORIA == null)
            {
                return NotFound();
            }

            return Ok(aCT_CATEGORIA);
        }

        // PUT: api/ACT_CATEGORIA/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutACT_CATEGORIA(int id, ACT_CATEGORIA aCT_CATEGORIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aCT_CATEGORIA.ID_CATEGORIA)
            {
                return BadRequest();
            }

            db.Entry(aCT_CATEGORIA).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACT_CATEGORIAExists(id))
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

        // POST: api/ACT_CATEGORIA
        [ResponseType(typeof(ACT_CATEGORIA))]
        public async Task<IHttpActionResult> PostACT_CATEGORIA(ACT_CATEGORIA aCT_CATEGORIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACT_CATEGORIA.Add(aCT_CATEGORIA);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aCT_CATEGORIA.ID_CATEGORIA }, aCT_CATEGORIA);
        }

        // DELETE: api/ACT_CATEGORIA/5
        [ResponseType(typeof(ACT_CATEGORIA))]
        public async Task<IHttpActionResult> DeleteACT_CATEGORIA(int id)
        {
            ACT_CATEGORIA aCT_CATEGORIA = await db.ACT_CATEGORIA.FindAsync(id);
            if (aCT_CATEGORIA == null)
            {
                return NotFound();
            }

            db.ACT_CATEGORIA.Remove(aCT_CATEGORIA);
            await db.SaveChangesAsync();

            return Ok(aCT_CATEGORIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACT_CATEGORIAExists(int id)
        {
            return db.ACT_CATEGORIA.Count(e => e.ID_CATEGORIA == id) > 0;
        }
    }
}