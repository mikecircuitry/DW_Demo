using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DW_Demo.Models;
using DW_Demo.Models.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DW_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {

        private CustomerContext _customerDb;

        public CustomerController(CustomerContext customerContext)
        {
            _customerDb = customerContext;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _customerDb.Customers.ToList();
            return Ok(customers);
        }

        [HttpGet("{id}/address")]
        public async Task<IActionResult> GetCustmerAddress(int id)
        {
            var addresses = await _customerDb.Addresses.Where(x => x.CustomerID == id).ToListAsync();

            return Ok(addresses);
        }
    }
}