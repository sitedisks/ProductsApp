using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Model;

namespace ProductsApp.Controller
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return Factory.Create();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = Factory.Create().FirstOrDefault(c => c.Id == id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }
    }
}
