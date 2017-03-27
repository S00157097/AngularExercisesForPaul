using APM.WebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APM.WebAPI.Controllers
{
    [EnableCors("http://localhost:52436", "*", "*")]
    public class ProductsController : ApiController
    {
        private ProductRepository ctx;

        public ProductsController()
        {

        }

        public ProductsController(ProductRepository ctx)
        {
            this.ctx = ctx;
        }


        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return this.ctx.Retrieve();
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(
                this.ctx.Retrieve().Where(p => p.ProductId == id)
                );
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
