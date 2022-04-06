using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Models
{
    //Admin profile
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Profile> Profiles { get; internal set; }

        public ApplicationDbContext(DbContextOptions
            <ApplicationDbContext> options)
            :base(options)
        { }

    }
}

