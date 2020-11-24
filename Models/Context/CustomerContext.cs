using Microsoft.EntityFrameworkCore;

namespace DW_Demo.Models.Context
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options){}
    }
}