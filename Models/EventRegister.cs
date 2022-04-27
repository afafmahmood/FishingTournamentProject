using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;
using FishingTournament02.Models;

namespace FishingTournament02.Models
{
    public class EventRegister
    {
        [Key]
        public int RegisterId { get; set; }

        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is is not valid.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "Employee First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Employee Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }


        [StringLength(24)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Guest First Name is required")]
        [Display(Name = "Guest First Name")]
        [StringLength(160)]
        public string GuestFirstName { get; set; }

        [Required(ErrorMessage = "Guest Last Name is required")]
        [Display(Name = "Guest Last Name")]
        [StringLength(160)]
        public string GuestLastName { get; set; }
        public int EventID { get; set; }
        public Events Events { get; set; }
    }
}
