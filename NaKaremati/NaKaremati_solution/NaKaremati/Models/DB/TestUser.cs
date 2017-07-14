using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class TestUser : IdentityUser
    {
        public User user { get; set; }
    }

    public class TestRole : IdentityRole
    {
        public TestRole() : base() { }
        public TestRole(string name) : base(name) { }
    }


}