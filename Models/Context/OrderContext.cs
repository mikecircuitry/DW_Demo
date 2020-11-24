using Microsoft.EntityFrameworkCore;

namespace DW_Demo.Models.Context
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
    }
}