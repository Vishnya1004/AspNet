using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
      public class OrderItemMetadata
    {
        public int Id { get; set; }
        public Good Good { get; set; }
        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}