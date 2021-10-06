using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L01SampleAuth.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required,Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Username")]
        public override string UserName { get; set; }

        [Required, Display(Name = "Email")]
        public override string Email { get; set; }

        [Display(Name = "PhoneNumber")]
        public override string PhoneNumber { get; set; }

        [Display(Name = "BirthDate")]
        public DateTime? BirthDate { get; set; }
    }
}
