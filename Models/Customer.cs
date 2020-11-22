using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;

namespace DW_Demo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public DateTime CreateDate  { get; set; }
        public List<Address> Addresses { get; set; }
        

    }

    public class Address
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime CreateDate { get; set; }


    }
}