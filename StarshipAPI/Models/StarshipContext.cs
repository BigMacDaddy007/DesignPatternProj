using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StarshipAPI.Models;

namespace StarshipAPI.Models
{
    public class StarshipContext : DbContext
    {
        public StarshipContext(DbContextOptions<StarshipContext> options)
            : base(options)
        {
        }

        public DbSet<Crewmate> Crewmate { get; set; }

        public DbSet<Ship> Ship { get; set; }

        public DbSet<Finance> Finance { get; set; }

        public DbSet<ModuleUnitRoom> ModuleUnitRoom { get; set; }

        public DbSet<Operator> Operator { get; set; }
        public DbSet<ShipModuleUnitRoom> ShipModuleUnitRoom { get; set; }
    }
}
