using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication_AdoNet.Models
{
    //during migration data is lost
    public class MyStoreDbInitializer : DropCreateDatabaseIfModelChanges<MyStoreContext>
    {
        protected override void Seed(MyStoreContext context)
        {
            //context.Goods.Add
            //    (new Good
            //    {
            //        Id = 1,
            //        Name = "Good 1",
            //        DateOfAdding = DateTime.Now,
            //        Description = "Description Test",
            //        Price = 12.4m
            //    }
            //    );

            

            base.Seed(context);
        }
    }
}