using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models.DbModels
{
    public class Good
    {
        public int Id { get; set; }
        [StringLength(10, ErrorMessage = "{The name can`t contains more than 10 or less than 1 symbol!}", MinimumLength=1)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [StringLength(15, ErrorMessage = "{The name can`t contains more than 10 or less than 1 symbol!}", MinimumLength = 2)]
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