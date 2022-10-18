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
    public class PROVEEDORESController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/PROVEEDORES
        public IQueryable<PROVEEDORES> GetPROVEEDORES()
        {
            return db.PROVEEDORES;
        }

        // GET: api/PROVEEDORES/5
        [ResponseType(typeof(PROVEEDORES))]
        public async Task<IHttpActionResult> GetPROVEEDORES(int id)
        {
            PROVEEDORES pROVEEDORES = await db.PROVEEDORES.FindAsync(id);
            if (pROVEEDORES == null)
            {
                return NotFound();
            }

            return Ok(pROVEEDORES);
        }

        // PUT: api/PROVEEDORES/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPROVEEDORES(int id, PROVEEDORES pROVEEDORES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pROVEEDORES.ID_PROVEEDOR)
            {
                return BadRequest();
            }

            db.Entry(pROVEEDORES).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PROVEEDORESExists(id))
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

        // POST: api/PROVEEDORES
        [ResponseType(typeof(PROVEEDORES))]
        public async Task<IHttpActionResult> PostPROVEEDORES(PROVEEDORES pROVEEDORES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PROVEEDORES.Add(pROVEEDORES);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pROVEEDORES.ID_PROVEEDOR }, pROVEEDORES);
        }

        // DELETE: api/PROVEEDORES/5
        [ResponseType(typeof(PROVEEDORES))]
        public async Task<IHttpActionResult> DeletePROVEEDORES(int id)
        {
            PROVEEDORES pROVEEDORES = await db.PROVEEDORES.FindAsync(id);
            if (pROVEEDORES == null)
            {
                return NotFound();
            }

            db.PROVEEDORES.Remove(pROVEEDORES);
            await db.SaveChangesAsync();

            return Ok(pROVEEDORES);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PROVEEDORESExists(int id)
        {
            return db.PROVEEDORES.Count(e => e.ID_PROVEEDOR == id) > 0;
        }
    }
}