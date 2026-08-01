using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Models;


namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
            
        }
        [HttpGet]
        [Route("ProductsList")]
        public IActionResult GetProductsList()
         {
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000
            },

            new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 30000
            },

            new Product
            {
                Id = 3,
                Name = "Keyboard",
                Price = 2000
            },
             new Product
            {
                Id = 3,
                Name = "Keyboard",
                Price = 2100
            },
              new Product
            {
                Id = 5,
                Name = "Mouse 11:03",
                Price = 2155
            },
              new Product
            {
                Id = 6,
                Name = "Keyboard",
                Price = 2155
            },
              new Product
            {
                Id = 7,
                Name = "Wired Mouse",
                Price = 3000
            },
              new Product
            {
                Id = 8,
                Name = "Wireless Mouse",
                Price = 5000
            }
        };

        return Ok(products);
        //return new OkObjectResult(products); roslyn doest no ok it converts into class OkObjectResult
    }
    }
}