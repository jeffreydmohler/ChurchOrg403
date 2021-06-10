using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurchOrganization.Models
{
    public class Units
    {
        [Required]
        [Display(Name = "Unit Code")]
        public int unitCode { get; set; }

        [Required(ErrorMessage = "Unit must be given a name.")]
        [Display(Name = "Unit")]
        public string unitName { get; set; }

        [Required]
        [Display(Name = "Unit Type")]
        public string unitType { get; set; }

        [Required(ErrorMessage = "Unit must be given a location")]
        [Display(Name = "Location")]
        public string unitLocation { get; set; }
    }
}