using System.Collections.Generic;
using DW_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DW_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>{
                new Product{Id = 1, Name = "Bonsai Lamp", Price = 149.99, IsActive = true, Description = "Bonsia plant bluetooth speaker with charing station at base"}
            };
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }

    }
}