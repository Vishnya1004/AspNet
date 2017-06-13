using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(OrderMetadata))]
    [ValidationOrderDate(ErrorMessage = "The dates are not correct!")]
    public partial class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [DisplayName("Finish Date")]
        public DateTime FinishDate { get; set; }
        public Discount Discount { get; set; }
        public int? ExtraDiscount { get; set; }
    }
}