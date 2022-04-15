using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FishingTournament02.Models
{
    public class PhotoDbContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public PhotoDbContext(
            DbContextOptions<PhotoDbContext> options)
            : base(options)
        {
        }
    }
}

