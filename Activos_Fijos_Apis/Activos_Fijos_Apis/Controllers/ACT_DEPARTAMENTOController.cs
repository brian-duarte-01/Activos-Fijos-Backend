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
    [EnableCors(origins: "http://localhost:4200", headers:"*",methods:"*")]
    public class ACT_DEPARTAMENTOController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ACT_DEPARTAMENTO
        public IQueryable<ACT_DEPARTAMENTO> GetACT_DEPARTAMENTO()
        {
            return db.ACT_DEPARTAMENTO;
        }

        // GET: api/ACT_DEPARTAMENTO/5
        [ResponseType(typeof(ACT_DEPARTAMENTO))]
        public async Task<IHttpActionResult> GetACT_DEPARTAMENTO(int id)
        {
            ACT_DEPARTAMENTO aCT_DEPARTAMENTO = await db.ACT_DEPARTAMENTO.FindAsync(id);
            if (aCT_DEPARTAMENTO == null)
            {
                return NotFound();
            }

            return Ok(aCT_DEPARTAMENTO);
        }

        // PUT: api/ACT_DEPARTAMENTO/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutACT_DEPARTAMENTO(int id, ACT_DEPARTAMENTO aCT_DEPARTAMENTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aCT_DEPARTAMENTO.ID_DEPARTAMENTO)
            {
                return BadRequest();
            }

            db.Entry(aCT_DEPARTAMENTO).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACT_DEPARTAMENTOExists(id))
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

        // POST: api/ACT_DEPARTAMENTO
        [ResponseType(typeof(ACT_DEPARTAMENTO))]
        public async Task<IHttpActionResult> PostACT_DEPARTAMENTO(ACT_DEPARTAMENTO aCT_DEPARTAMENTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACT_DEPARTAMENTO.Add(aCT_DEPARTAMENTO);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aCT_DEPARTAMENTO.ID_DEPARTAMENTO }, aCT_DEPARTAMENTO);
        }

        // DELETE: api/ACT_DEPARTAMENTO/5
        [ResponseType(typeof(ACT_DEPARTAMENTO))]
        public async Task<IHttpActionResult> DeleteACT_DEPARTAMENTO(int id)
        {
            ACT_DEPARTAMENTO aCT_DEPARTAMENTO = await db.ACT_DEPARTAMENTO.FindAsync(id);
            if (aCT_DEPARTAMENTO == null)
            {
                return NotFound();
            }

            db.ACT_DEPARTAMENTO.Remove(aCT_DEPARTAMENTO);
            await db.SaveChangesAsync();

            return Ok(aCT_DEPARTAMENTO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACT_DEPARTAMENTOExists(int id)
        {
            return db.ACT_DEPARTAMENTO.Count(e => e.ID_DEPARTAMENTO == id) > 0;
        }
    }
}