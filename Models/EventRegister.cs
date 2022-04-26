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

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public string Email { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "ZIP Code is required")]
        public string ZIP { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "Guest First Name is required")]
        public string GuestFirstName { get; set; }

        [Required(ErrorMessage = "Guest Last Name is required")]
        public string GuestLastName { get; set; }
        public int EventID { get; set; }
        public Events Events { get; set; }
    }
}
