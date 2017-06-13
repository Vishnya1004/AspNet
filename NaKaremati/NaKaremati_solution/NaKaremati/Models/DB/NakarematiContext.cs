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
        public DbSet<User> Users { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<GoodReview> GoodReviews { get; set; }
        public DbSet<Good> Good { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Discount> Discounts { get; set; }


        public NakarematiContext() : base ("NaKaremati")
        {
          
        }
    }
}