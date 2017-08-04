using NaKaremati.Models;
using NaKaremati.Models.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NaKaremati.Controllers
{
    public class RentController : Controller
    {
        NaKarematiConnectionSettings db = new NaKarematiConnectionSettings();

        // GET: ViewModel
        public ActionResult Index()
        {
            List<ActivityVM> activitiesVM = new List<ActivityVM>();

            foreach (Activity activity in db.Activities)
            {
                activitiesVM.Add(new ActivityVM(activity.Id));
            }
           
            return View(activitiesVM);
        }

        public ActionResult GetGoodsByCategory(int categoryId = 0)
        {
            Category category = (Category)db.Categories.Include("Goods").Where(c => c.Id == categoryId).First();
            List<Good> goods = category.Goods.ToList();
            List<GoodVM> goodsVM = new List<GoodVM>();
     
            foreach (Good good in goods)
            {
                goodsVM.Add(new GoodVM(good.Id, categoryId));
            }

            return PartialView("_ViewGoods", goodsVM);
        }

        public ActionResult GetGoodDetails(int goodId = 0, int categoryId = 0)
        {
            GoodVM goodVM = new GoodVM(goodId, categoryId);
            
            return View("GoodDetails", goodVM);
        }


        public ActionResult GetGoodsExceptSelected(int selectedGoodId = 0, int categoryId = 0)
        {
            Category category = (Category)db.Categories.Include("Goods").Where(c => c.Id == categoryId).First();
            List<Good> goods = category.Goods.ToList();
            List<GoodVM> goodsVM = new List<GoodVM>();

            foreach (Good good in goods)
            {
                if(good.Id != selectedGoodId)
                {
                    goodsVM.Add(new GoodVM(good.Id, categoryId));
                }
                
            }


            return PartialView("_ViewGoodsListImg", goodsVM);
        }


    }
}