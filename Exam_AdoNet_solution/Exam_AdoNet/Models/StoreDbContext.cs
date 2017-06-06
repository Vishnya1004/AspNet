using Exam_AdoNet.Models;
using Exam_AdoNet.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StoreDbContext() :base("Store")
        {

        }

        public System.Data.Entity.DbSet<Exam_AdoNet.Models.OrderItem> OrderItems { get; set; }
    }
}