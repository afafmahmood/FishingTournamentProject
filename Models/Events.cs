using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventAddress { get; set; }
        public string EventCity { get; set; }
        public string EventState { get; set; }
        public string EventZipCode { get; set; }
        public string EventPhone { get; set; }
        public int EventCapacity { get; set; }
        public string EventURL { get; set; }
        public string EventCost { get; set; }
    }
}

