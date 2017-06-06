using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models.DbModels
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        
        //Field for DB Table Constructor
        public ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

    }
}