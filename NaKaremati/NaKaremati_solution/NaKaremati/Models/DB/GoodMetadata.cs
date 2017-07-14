using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class GoodMetadata
    {
        public int Id { get; set; }
        public Producer Producer { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please, enter not less than 3 and not more than 30 characters!")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 50000)]
        [DisplayName("Deposit Price")]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 1000)]
        [DisplayName("Price Rent")]
        public decimal RentPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 50000)]
        [DisplayName("Deposit Price")]
        public decimal DepositPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [DisplayName("Weigth, gram")]
        public decimal Weigth { get; set; }

        [StringLength(150, ErrorMessage = "To much characters! Please, enter not more than 150!")]
        public string Description { get; set; }

        [StringLength(150, ErrorMessage = "To much characters! Please, enter not more than 150!")]
        public string Damages { get; set; }

        public string Img { get; set; }

        public ICollection<GoodReview> GoodReviews { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}