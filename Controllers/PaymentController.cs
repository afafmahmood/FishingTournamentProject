using FishingTournament02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Controllers
{ 
    public class PaymentController : Controller
    {
        private readonly Database1Context db;
        public PaymentController(Database1Context db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
