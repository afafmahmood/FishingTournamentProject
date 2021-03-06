using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Models
{
    public class PhotoDbContext : DbContext

    {
        public DbSet<Photo> Photos { get; set; }

        public PhotoDbContext(
            DbContextOptions <PhotoDbContext> options)
            :base(options)
        {

        }
    }
}
