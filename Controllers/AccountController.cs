using FishingTournament02.Models;
using FishingTournament02.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private RoleManager<IdentityRole> roleManager;
        

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.db = db;
        }
                
        public IActionResult Register()
        {
            return View();
        }


        
        [HttpPost]

        public async Task<IActionResult> Register(AccountRegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = vm.Email, Email = vm.Email };
                var result = await userManager.CreateAsync(user, vm.Password);
                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(vm.Email);
                var roles = await userManager.GetRolesAsync(user);
                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Admin");
                }

                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(vm);
        }
    [HttpPost]
        public  IActionResult AllUser()
        {
            var users = db.Users.ToList();
            return View(users);
        }

        public IActionResult AllEvent()
        {
            var events = db.Events.ToList();
            return View(events);
        }

        public async Task<IActionResult> EventRegister(int? id)
        {
            var events = await db.Events.SingleOrDefaultAsync(e => e.EventID == id);
            ViewBag.Event = events;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EventRegister(EventRegister eventRegister)
        {
            db.Add(eventRegister);
            var events = await db.Events.FindAsync(eventRegister.EventID);
            events.EventCapacity++;
            await db.SaveChangesAsync();
            return RedirectToAction("Confirmation", "Account");
        }


        public IActionResult Confirmation()
        {
            return View();
        }


    }
}
    
// Login added 




