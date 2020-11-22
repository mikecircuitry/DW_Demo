using System;
using System.Collections.Generic;

namespace DW_Demo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CreateDate { get; set; }
        public List<OrderItem> OrderDetails { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    }
}