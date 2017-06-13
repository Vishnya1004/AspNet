using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class ValidationOrderDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (((Order)value).StartDate.Date >= ((Order)value).OrderDate.Date && ((Order)value).StartDate.Date < ((Order)value).FinishDate.Date)
            return true;
            return false;
        }
    }
}