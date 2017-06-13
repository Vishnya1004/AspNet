using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class DiscountMetadata
    {
        public int Id { get; set; }
        [Required]
        [Range(5, 30, ErrorMessage = "The discount can`t variate in 5% - 30% diapason only!")]
        public int Percent { get; set; }
    }
}