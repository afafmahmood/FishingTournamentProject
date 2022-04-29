using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingTournament02.Models
{
    public class PictureDbContext : DbContext

    {
        public DbSet<Picture>Pictures { get; set; }
        public PictureDbContext(
            DbContextOptions <PictureDbContext> options)
            :base(options)
        {

        }
    }
}
