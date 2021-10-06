using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace L01SampleAuth.Models
{
    public class Team
    {
        [Key, Display(Name = "Id")]
        public int Id { get; set; }

        [Required,Display(Name = "Team Name")]
        public string TeamName{ get; set; }

        [Required, Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Established Date")]
        public DateTime? EstablishedDate{ get; set; }
    }
}
