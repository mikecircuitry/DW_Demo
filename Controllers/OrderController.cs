using System;
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
    public class OrderController : Controller
    {

        private OrderContext _orderContext;

        public OrderController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitOrder(Order model)
        {
            try
            {
                _orderContext.Add(model);
                await _orderContext.SaveChangesAsync();

                return Ok(model.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/recent/{customerId}")]
        public async Task<IActionResult> GetRecentOrders(int customerId)
        {
            try
            {
                var orders = await (from o in _orderContext.Orders
                                    where o.CustomerID == customerId
                                    select o).ToListAsync();

                return Ok(orders);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}