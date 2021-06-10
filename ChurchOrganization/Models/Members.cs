using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChurchOrganization.Models
{
    public class Members
    {
        [Required(ErrorMessage = "Membership Number is required.")]
        [Range(1000,9999999999, ErrorMessage = "Membership Number must be between 4 and 10 characters long.")]
        [Display(Name = "Membership Number")]
        public int membershipNumber { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "First Name must be between 1 and 10 character long.")]
        [Display(Name = "First Name")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Last Name must be between 1 and 10 character long.")]
        [Display(Name = "Last Name")]
        public string lName { get; set; }

        [EmailAddress(ErrorMessage = "This must be a valid email address")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Unit")]
        public string unitName { get; set; }

        [Display(Name = "Calling")]
        public string callingName { get; set; }
    }
}