using NaKaremati.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaKaremati.Models
{
    public class ActivityVM
    {
        public ActivityVM(int activityId)
        {
            db = new NaKarematiConnectionSettings();
            Activity = (Activity)db.Activities.Include("Categories").Where(a => a.Id == activityId).First();
            Categories = Activity.Categories;
        }

        private NaKarematiConnectionSettings db;
        public Activity Activity { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}