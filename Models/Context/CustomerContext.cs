using System;
using Microsoft.EntityFrameworkCore;

namespace DW_Demo.Models.Context
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Johnny Test", Email = "Johnny@testlabs.com", CreateDate = DateTime.Now },
                new Customer { Id = 2, Name = "Susan Test", Email = "Susan@testlabs.com", CreateDate = DateTime.Now },
                new Customer { Id = 3, Name = "Mary Test", Email = "Mary@testlabs.com", CreateDate = DateTime.Now }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, CustomerID = 1, Name = "Home", StreetAddress = "123 Test Way Drive", City = "Pork Belly", State = "NY", Zip = "11111", CreateDate = DateTime.Now },
                new Address { Id = 2, CustomerID = 2, Name = "Home", StreetAddress = "123 Test Way Drive", City = "Pork Belly", State = "NY", Zip = "11111", CreateDate = DateTime.Now },
                new Address { Id = 3, CustomerID = 2, Name = "School", StreetAddress = "314 University Way", City = "Pork Belly", State = "NY", Zip = "22222", CreateDate = DateTime.Now },
                new Address { Id = 4, CustomerID = 3, Name = "Secret Lab", StreetAddress = "360 redacted street", City = "Pork Belly", State = "NY", Zip = "33333", CreateDate = DateTime.Now },
                new Address { Id = 5, CustomerID = 3, Name = "Home", StreetAddress = "123 Test Way Drive", City = "Pork Belly", State = "NY", Zip = "11111", CreateDate = DateTime.Now }
             );
        }
    }
}