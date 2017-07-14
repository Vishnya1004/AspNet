using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class CategoryMetadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The field can`t contain more than 20 symbols")]
        [DisplayName("Category")]

        public string Name { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Good> Goods { get; set; }
    }
}