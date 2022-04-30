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
    public class HomeController : Controller
    {
        //[Authorize]

        Database1Context db;
        UserManager<ApplicationUser> userManager;
        RoleManager<IdentityRole> roleManager;
        public HomeController(Database1Context db,
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

       
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ContactUs(ContactUs ContactUs)
        {
            db.Add(ContactUs);
            await db.SaveChangesAsync();
            return RedirectToAction("MessageSent", "Home");
        }
       

        
        public IActionResult MessageSent()
        {
            return View();
        }
        /*
        [HttpPost]
        public async Task<IActionResult> MessageSent(MessageSent MessageSent)
        {
            db.Add(MessageSent);
            await db.SaveChangesAsync();
            return RedirectToAction("ContactUs");
        }
        */
    }
}
