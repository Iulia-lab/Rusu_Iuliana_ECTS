using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Iuliana_ECTS.Models;

namespace Rusu_Iuliana_ECTS.Data
{
    public class Rusu_Iuliana_ECTSContext : DbContext
    {
        public Rusu_Iuliana_ECTSContext (DbContextOptions<Rusu_Iuliana_ECTSContext> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Iuliana_ECTS.Models.Biscuit> Biscuit { get; set; } = default!;

        public DbSet<Rusu_Iuliana_ECTS.Models.Publisher> Publisher { get; set; } =default!;

        public DbSet<Rusu_Iuliana_ECTS.Models.Cantitate> Cantitate { get; set; }
    }
}
