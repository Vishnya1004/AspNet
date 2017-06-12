using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class NakarematiContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Category> Categories { get; set; }

        public NakarematiContext() : base ("NaKaremati")
        {
          
        }
    }
}