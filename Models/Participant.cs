using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Models
{
        public class Participant
        {
            public int ParticipantId { get; set; }
            public string ParticipantName { get; set; }
            public string ParticipantPhone { get; set; }
            public string ParticipantEvent { get; set; }
        }
}