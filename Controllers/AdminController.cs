using FishingTournament02.Models;
using FishingTournament02.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Controllers
{
    // [Authorize(Roles = "Admin")]  
    public class AdminController : Controller
    {

        Database1Context db;
        UserManager<ApplicationUser> userManager;
        RoleManager<IdentityRole> roleManager;
        public AdminController(Database1Context db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.roleManager = roleManager;

        }
        public IActionResult AllRole()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            var result = await roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("AllRole");
            }
            return View();
        }
        public async Task<IActionResult> AddUserRole(string id)
        {
            var roleDisplay = db.Roles.Select(x => new
            {
                Id = x.Id,
                Value = x.Name
            }).ToList();
            RoleAddUserRoleViewModel vm = new RoleAddUserRoleViewModel();
            var user = await userManager.FindByIdAsync(id);
            var roles = await userManager.GetRolesAsync(user);
            vm.User = user;
            vm.RoleList = new SelectList(roleDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserRole
            (RoleAddUserRoleViewModel vm)
        {
            var user = await userManager.FindByIdAsync(vm.User.Id);
            var role = await roleManager.FindByIdAsync(vm.Role);
            var result = await userManager.
                AddToRoleAsync(user, role.Name);
            if (result.Succeeded)
            {
                return RedirectToAction("AllUser", "Admin");

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code,
                    error.Description);

            }
            var roleDisplay = db.Roles.Select(x => new
            {
                Id = x.Id,
                Value = x.Name
            }).ToList();
            vm.User = user;
            vm.RoleList = new SelectList(roleDisplay, "Id", "Value");
            return View(vm);

        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult AllUser()
        {
            var users = db.Users.ToList();
            return View(users);
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
        public async Task<IActionResult> AddEvent(Events Event)
        {
            db.Add(Event);
            await db.SaveChangesAsync();
            return RedirectToAction("AllEvent");
        }


        //public IActionResult AllProfile()
        //{
        //    var profiles = db.Profiles.ToList();
        //    return View(profiles);
        //}


        //public IActionResult AddProfile()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddProfile(Profile profile)
        //{
        //    db.Add(profile);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("AllProfile");
        //}


        public IActionResult AllParticipant()
        {
            return View(db.EventRegisters);
        }

        // GET: /<controller>/
        public async Task<IActionResult> AddParticipant(int? id)
        {
            var events = await db.Events.SingleOrDefaultAsync(e => e.EventID == id);
            ViewBag.Event = events;
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddParticipant(EventRegister eventRegister)
        {
            db.Add(eventRegister);
            var events = await db.Events.FindAsync(eventRegister.EventID);
            events.EventCapacity--;
            await db.SaveChangesAsync();
            return RedirectToAction("AllParticipant");
        }




        public IActionResult EditParticipant(int id)
        {
            EventRegister eventRegister;
            eventRegister = db.EventRegisters.Find(id);
            return View(eventRegister);
        }

        [HttpPost]
        public async Task <IActionResult> EditParticipant(EventRegister eventRegister)
        {
            db.Update(eventRegister);
            await db.SaveChangesAsync();
            //db.SaveChanges();
            return RedirectToAction("AllParticipant");
        }

        public IActionResult DeleteParticipant(int id)
        {
            EventRegister eventRegister;
            eventRegister = db.EventRegisters.Find(id);
            return View(eventRegister);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteParticipantAsync(EventRegister eventRegister)
        {
            db.Remove(eventRegister);
            var events = await db.Events.FindAsync(eventRegister.EventID);
            events.EventCapacity++;
            db.SaveChanges();
            return RedirectToAction("AllParticipant");
        }

        public IActionResult ViewMessages()
        {
            var contactUs = db.ContactUs.ToList();
            return View(contactUs);
        }
    }
}

