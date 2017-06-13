using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Activity> Activities { get; set; }
        public List<Good> Goods { get; set; }
    }
}