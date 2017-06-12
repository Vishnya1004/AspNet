using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class ActivityMetadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The field can`t contain more than 20 symbols")]
        [Display(Name = "Activity")]
        public string Name { get; set; }
    }
}