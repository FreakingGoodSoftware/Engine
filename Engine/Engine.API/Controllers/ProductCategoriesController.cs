using Engine.API.Filters;
using Engine.API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Engine.API.Controllers
{
    [HttpOperationExceptionFilterAttribute]
    public class ProductCategoriesController : ApiController
    {
        private static EngineDataAPI NewEngineDataAPIClient()
        {
            var client = new EngineDataAPI(new Uri(ConfigurationManager.AppSettings["DataAPIURL"]));

            return client;
        }
        // GET: api/ProductCategories
        public async Task<IEnumerable<ProductCategoryDTO>> GetProductCategories()
        {
            using (var client = NewEngineDataAPIClient())
            {
                var results = await client.ProductCategories.GetProductCategoriesAsync();
                return results;
            }
        }

        // GET: api/ProductCategories/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductCategories
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductCategories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductCategories/5
        public void Delete(int id)
        {
        }
    }
}
