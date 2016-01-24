using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "iPhone 2G", Category = "Electronics", Price = 80M },
            new Product { Id = 2, Name = "iPhone 3GS", Category = "Electronics", Price = 300M },
            new Product { Id = 3, Name = "iPhone 4S", Category = "Electronics", Price = 550M },
            new Product { Id = 4, Name = "iPhone 5S", Category = "Electronics", Price = 900M },
            new Product { Id = 5, Name = "iPhone 6", Category = "Electronics", Price = 1081M },
            new Product { Id = 6, Name = "iPhone 6S", Category = "Electronics", Price = 1200M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
