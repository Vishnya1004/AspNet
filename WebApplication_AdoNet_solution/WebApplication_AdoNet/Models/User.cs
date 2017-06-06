using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication_AdoNet.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

    }
}