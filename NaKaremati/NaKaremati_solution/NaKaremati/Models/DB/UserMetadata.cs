using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaKaremati.Models.DB
{
    public class UserMetadata
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "The field can`t contain more than 20 symbols")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not correct format!")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Please, check if the number is correct!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Not correct format!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Please, check if the mail is correct!")]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}