using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurchOrganization.Models
{
    public class Callings
    {
        [Required]
        [Display(Name = "Calling ID")]
        public int callingCode { get; set; }

        [Required(ErrorMessage = "The calling must be given a name.")]
        [Display(Name = "Calling")]
        public string callingName { get; set; }

        [Required(ErrorMessage = "The calling must be assigned an Organization.")]
        [Display(Name = "Organization")]
        public string callingOrganization { get; set; }
    }
}