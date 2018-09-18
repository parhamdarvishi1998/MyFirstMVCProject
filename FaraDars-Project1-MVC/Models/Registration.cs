using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FaraDars_Project1_MVC.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string FullName { get; set; }

        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Your Email Format is incorrect,Please Correct it")]
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Your PhoneNumber")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Please Select Your Chiose")]
        public bool? SendNotification { get; set; }
        
    }
}