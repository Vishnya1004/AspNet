using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(GoodReviewMetadata))]
    public partial class GoodReview
    {
        public int Id { get; set; }
        public Good Good { get; set; }
        public User User { get; set; }
        public string Body { get; set; }
    }
}