using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Html5_Validations.Models
{
    public class UserProfileModel
    {
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
       public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }


        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Gender")]
        public bool Gender { get; set; }


        [Display(Name = "Degree")]
        public string Degree { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Agreement")]
        public bool Agreement { get; set; }

        [Display(Name = "MaritalStatus")]
        public bool MaritalStatus { get; set; }
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}