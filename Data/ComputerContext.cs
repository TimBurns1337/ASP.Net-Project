using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Models
{
    public class ComputerContext : DbContext
    {
        public ComputerContext(DbContextOptions<ComputerContext> options)
            : base(options)
        { }

        public DbSet<GamingPC> GamingPCs { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Hdd> Hdds { get; set; }
        public DbSet<Power> Powers { get; set; }


        // add your db sets below inside this method - used DbInitializer for data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamingPC>().ToTable("GamingPcs");
            modelBuilder.Entity<Purchase>().ToTable("Purchases");
            modelBuilder.Entity<Ram>().ToTable("Rams");
            modelBuilder.Entity<Hdd>().ToTable("Hdds");
            modelBuilder.Entity<Power>().ToTable("Powers");
        }
    }
}
