using System;

namespace DW_Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}