using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_AdoNet.Models.DbModels
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

        //Field for DB Table Constructor
        public ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}