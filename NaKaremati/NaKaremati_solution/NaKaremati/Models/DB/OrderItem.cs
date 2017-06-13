using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(OrderItemMetadata))]
    public partial class OrderItem
    {
        public int Id { get; set; }
        public Good Good { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}