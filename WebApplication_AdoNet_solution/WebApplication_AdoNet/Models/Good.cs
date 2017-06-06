using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_AdoNet.Models
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateOfAdding { get; set; }

        int a = 0;
    }
}