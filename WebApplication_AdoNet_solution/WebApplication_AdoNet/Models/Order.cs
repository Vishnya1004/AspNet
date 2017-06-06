
using System;

namespace WebApplication_AdoNet.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Good Good { get; set; }
        public User User { get; set; }
        public double Quantity { get; set; }
        public DateTime Date { get; set; }

    }

    public class OrderViewModel
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public double Quantity { get; set; }
        public DateTime Date { get; set; }

    }
}