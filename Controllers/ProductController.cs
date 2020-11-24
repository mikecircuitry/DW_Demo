using System.Collections.Generic;
using System.Threading.Tasks;
using DW_Demo.Models;
using DW_Demo.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DW_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private List<Product> _products;
        private ProductContext _productsContext;

        public ProductController(ProductContext productContext)
        {
            _productsContext = productContext;
            _products = new List<Product>{
                new Product{Id = 1, Name = "Bonsai Lamp", Price = 149.99, IsActive = true, Description = "Bonsia plant bluetooth speaker with charing station at base"}
            };
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            var products = await _productsContext.Products.ToListAsync();
            return Ok(products);
        }

    }
}