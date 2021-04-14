using System;
using Microsoft.EntityFrameworkCore;

namespace BandFinder.Models
{
    public class ApplicationDbContext: DbContext
    {

         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<BandConcert> BandConcert { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BandConcert>()
                .HasKey(c => new { c.ConcertID, c.BandID });
        }
    }
}
