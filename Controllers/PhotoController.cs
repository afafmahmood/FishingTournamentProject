using Microsoft.AspNetCore.Mvc;
using FishingTournament02.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FishingTournament02.Controllers
{
    public class PhotoController : Controller
    {
        private readonly PhotoDbContext db;
        public PhotoController(PhotoDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPhoto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPhoto(Photo p)
        {
            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot\\images",
                p.MyPhoto.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await p.MyPhoto.CopyToAsync(stream);
            }
            p.Url = p.MyPhoto.FileName;
            db.Add(p);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DisplayPhoto()
        {
            var photo = await db.Photos.ToListAsync();
            return View(photo);
        }
    }
}