using FishingTournament02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Controllers
{
    public class ParticipantController : Controller
    {
        ApplicationDbContext db;
        public ParticipantController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult AllParticipant()
        {
            return View(db.Participants);
        }
        
        //GET: /<controller>/
        public IActionResult AddParticipant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddParticipant(Participant participant)
        {
            db.Add(participant);
            db.SaveChanges();
            return RedirectToAction("AllParticipant");
        }

        public IActionResult EditParticipant(int id)
        {
            Participant participant;
            participant = db.Participants.Find(id);
            return View(participant);
        }
    }
}
