using FishingTournament02.Models;
using FishingTournament02.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        




    }
}


