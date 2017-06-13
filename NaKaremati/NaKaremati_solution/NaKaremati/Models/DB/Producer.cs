using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(ProducerMetadata))]
    public partial class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}