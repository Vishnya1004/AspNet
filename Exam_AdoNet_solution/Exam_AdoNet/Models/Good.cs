using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models.DbModels
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateOfAdding { get; set; }

        //Field for DB Table Constructor
        public ICollection<OrderItem> OrderItems { get; set; }

        public Good()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}