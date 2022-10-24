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
    public class ACTIVOesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ACTIVOes
        public IQueryable<ACTIVO> GetACTIVO()
        {
            return db.ACTIVO;
        }

        // GET: api/ACTIVOes/5
        [ResponseType(typeof(ACTIVO))]
        public async Task<IHttpActionResult> GetACTIVO(int id)
        {
            ACTIVO aCTIVO = await db.ACTIVO.FindAsync(id);
            if (aCTIVO == null)
            {
                return NotFound();
            }

            return Ok(aCTIVO);
        }

        // PUT: api/ACTIVOes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutACTIVO(int id, ACTIVO aCTIVO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aCTIVO.ID_ACTIVO)
            {
                return BadRequest();
            }

            db.Entry(aCTIVO).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACTIVOExists(id))
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

        // POST: api/ACTIVOes
        [ResponseType(typeof(ACTIVO))]
        public async Task<IHttpActionResult> PostACTIVO(ACTIVO aCTIVO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACTIVO.Add(aCTIVO);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aCTIVO.ID_ACTIVO }, aCTIVO);
        }

        // DELETE: api/ACTIVOes/5
        [ResponseType(typeof(ACTIVO))]
        public async Task<IHttpActionResult> DeleteACTIVO(int id)
        {
            ACTIVO aCTIVO = await db.ACTIVO.FindAsync(id);
            if (aCTIVO == null)
            {
                return NotFound();
            }

            db.ACTIVO.Remove(aCTIVO);
            await db.SaveChangesAsync();

            return Ok(aCTIVO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACTIVOExists(int id)
        {
            return db.ACTIVO.Count(e => e.ID_ACTIVO == id) > 0;
        }
    }
}