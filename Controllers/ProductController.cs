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
        private ProductContext _productsContext;

        public ProductController(ProductContext productContext)
        {
            _productsContext = productContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            var products = await _productsContext.Products.ToListAsync();
            return Ok(products);
        }

    }
}