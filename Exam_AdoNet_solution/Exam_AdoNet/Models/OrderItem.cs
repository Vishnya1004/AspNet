using Exam_AdoNet.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        //Field for DB Table Constructor
        public Good Good { get; set; }
        public double Quantity { get; set; }
        public Order Order { get; set; }
        
        
    }
}