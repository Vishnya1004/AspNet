using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class ImageMetadata
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public Nullable<int> Good_Id { get; set; }

        public virtual Good Good { get; set; }
    }
}