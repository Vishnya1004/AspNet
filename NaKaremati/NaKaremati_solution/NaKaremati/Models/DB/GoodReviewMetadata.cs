using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class GoodReviewMetadata
    {
        public int Id { get; set; }
        public Good Good { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "To much characters! Please, enter not more than 5!")]
        [MinLength(5, ErrorMessage = "Not enough characters! Please, enter not less than 5!")]
        public string Body { get; set; }
    }
}