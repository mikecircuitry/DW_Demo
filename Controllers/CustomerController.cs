using System;
using System.Collections.Generic;
using DW_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DW_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        
        private Customer _sampleCustomer;
        public CustomerController() => _sampleCustomer = new Customer
        {
            Id = 1,
            Name = "Johnny Test",
            Email = "JohnnyTest@testlabs.com",
            CreateDate = DateTime.Now,
            Addresses = new List<Address>{
                new Address{
                    Id = 1,
                    StreetAddress = "123 test way",
                    City = "Pork Belly",
                    CustomerID = 1,
                    Name = "Default Address",
                    CreateDate = DateTime.Now,
                    State = "NY",
                    Zip = "11111"
                }
            }
        };

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_sampleCustomer);
        }
    }
}