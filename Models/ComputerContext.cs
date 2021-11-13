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

        //public DbSet<>
    }
}
