using NaKaremati.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NaKaremati.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            NakarematiContext db = new NakarematiContext();

            db.Activities.Add(new Activity { Name = "Test Activity" });
            db.Categories.Add(new Category { Name = "Test Category" });
            db.SaveChanges();



            return View();
        }
    }
}
