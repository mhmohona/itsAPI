using itsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace itsAPI.Controllers
{
    public class productController : ApiController
    {
        private List<Product> products = new List<Product>() {
            new Product {ID = 1, Name = "T Shirt", Price = 23M, Qty = 5 },
            new Product {ID = 2, Name = "Shirt", Price = 13M, Qty = 2 },
           };

      

        public IEnumerable<Product> Get()
        {
            return products.ToList();
        }
        public IHttpActionResult Get(int id)
        {
           var product = products.Where(x => x.ID == id);
            if (product == null)
                return NotFound();
            return Ok(product);

        }
    }
}
