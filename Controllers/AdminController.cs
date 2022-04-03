using FishingTournament02.Models;
using FishingTournament02.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Controllers
{
    // [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        ApplicationDbContext db;
        UserManager<ApplicationUser> userManager;
        RoleManager<IdentityRole> roleManager;
        public AdminController(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

            public IActionResult Index()
        {
            return View();
        }



       public IActionResult AllEvent()
        {
            var events = db.Events.ToList();
            return View(events);
        }

        public IActionResult AddEvent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEvent(Events events)
        {
            db.Add(events);
            await db.SaveChangesAsync();
            return RedirectToAction("AllEvent");
        }


    }
}


