using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(DiscountMetadata))]
    public partial class Discount
    {
        public int Id { get; set; }
        public int Percent { get; set; }
    }
}