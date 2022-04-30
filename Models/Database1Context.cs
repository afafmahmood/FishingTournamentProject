using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FishingTournament02.Models
{
    public class Database1Context: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Events> Events { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<EventRegister> EventRegisters { get; set; }
       

        public Database1Context(DbContextOptions
            <Database1Context> options)
            :base(options)
        { }

    }
}

