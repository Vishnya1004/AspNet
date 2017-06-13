using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NaKaremati.Models.DB
{
    [MetadataType(typeof(GoodMetadata))]
    public partial class Good
    {
        public int Id { get; set; }
        public Producer Produser { get; set; }
        public string Name { get; set; }
        public decimal RentPrice { get; set; }
        public decimal DepositPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Weigth { get; set; }
        public string Description { get; set; }

        public List<Category> Categories { get; set; }

    }
}