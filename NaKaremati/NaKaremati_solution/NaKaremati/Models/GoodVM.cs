using NaKaremati.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaKaremati.Models
{
    public class GoodVM
    {
        public GoodVM(int goodId, int selectedCategoryId = 0)
        {
            db = new NaKarematiConnectionSettings();
            Good = db.Goods.Include("Images").Include("Producer").Where(g => g.Id == goodId).First();
            SelectedCategoryId = selectedCategoryId;
            Images = Good.Images;
        }

        private NaKarematiConnectionSettings db;
        public Good Good { get; set; }
        public int SelectedCategoryId { get; set; }
        public ICollection<Image> Images { get; set; }

    }
}