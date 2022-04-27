using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FishingTournament02.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Events> Events { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<EventRegister> EventRegisters { get; set; }

        public ApplicationDbContext(DbContextOptions
            <ApplicationDbContext> options)
            :base(options)
        { }

    }
}

