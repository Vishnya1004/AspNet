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
            ViewBag.Title = "Index Page";
            //DbContextNaKaremati db = new DbContextNaKaremati();

            //db.Activities.Add(new Activity { Name = "Test Activity" });
            //db.Categories.Add(new Category { Name = "Test Category" });
            //db.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Page";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Title = "Gallery Page";

            return View();
        }

        public ActionResult Articles()
        {
            ViewBag.Title = "Articles Page";

            return View();
        }

        public ActionResult Partners()
        {
            ViewBag.Title = "Partners Page";

            return View();
        }

        public ActionResult BePartners()
        {
            ViewBag.Title = "BePartners Page";

            return View();
        }


        public ActionResult Autorization()
        {
            ViewBag.Title = "Autorization Page";

            return View();
        }


    }
}
