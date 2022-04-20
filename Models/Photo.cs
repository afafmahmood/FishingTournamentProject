using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FishingTournament02.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        [Required]
        public string AltAttribute { get; set; }
        [NotMapped]
        public IFormFile MyPhoto { get; set; }
        [Display(Name = "Enter Description:")]
        public string Description { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}
