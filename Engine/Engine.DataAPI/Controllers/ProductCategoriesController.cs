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
using Engine.DataAPI.Models;

namespace Engine.DataAPI.Controllers
{
    public class ProductCategoriesController : ApiController
    {
        private AdventureWorksModel db = new AdventureWorksModel();

        // GET: api/ProductCategories
        public IQueryable<ProductCategory> GetProductCategory()
        {
            return db.ProductCategory;
        }

        // GET: api/ProductCategories/5
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> GetProductCategory(int id)
        {
            ProductCategory productCategory = await db.ProductCategory.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }

            return Ok(productCategory);
        }

        // PUT: api/ProductCategories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProductCategory(int id, ProductCategory productCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productCategory.ProductCategoryID)
            {
                return BadRequest();
            }

            db.Entry(productCategory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoryExists(id))
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

        // POST: api/ProductCategories
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> PostProductCategory(ProductCategory productCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductCategory.Add(productCategory);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = productCategory.ProductCategoryID }, productCategory);
        }

        // DELETE: api/ProductCategories/5
        [ResponseType(typeof(ProductCategory))]
        public async Task<IHttpActionResult> DeleteProductCategory(int id)
        {
            ProductCategory productCategory = await db.ProductCategory.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }

            db.ProductCategory.Remove(productCategory);
            await db.SaveChangesAsync();

            return Ok(productCategory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductCategoryExists(int id)
        {
            return db.ProductCategory.Count(e => e.ProductCategoryID == id) > 0;
        }
    }
}