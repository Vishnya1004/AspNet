using NaKaremati.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaKaremati.Models
{
    public class GoodVM
    {
        public GoodVM(int goodId)
        {
            db = new NaKarematiConnectionSettings();
            Good = db.Goods.Include("Images").Include("Producer").Where(g => g.Id == goodId).First();
            Images = Good.Images;
        }

        private NaKarematiConnectionSettings db;
        public Good Good { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}