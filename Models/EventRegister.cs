using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace FishingTournament02.Models
{
    public class EventRegister
    {
        [Key]
        public int RegisterId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Guest First Name is required")]
        [DisplayName("Guest First Name")]
        [StringLength(160)]
        public string GuestFirstName { get; set; }

        [Required(ErrorMessage = "Guest Last Name is required")]
        [DisplayName("Guest Last Name")]
        [StringLength(160)]
        public string GuestLastName { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }
        public Events Event { get; set; }
    }
}
