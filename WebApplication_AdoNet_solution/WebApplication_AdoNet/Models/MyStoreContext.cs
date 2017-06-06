using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_AdoNet.Models
{
    public class MyStoreContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MyStoreContext() :base("MyStore")
        {

        }
    }
}