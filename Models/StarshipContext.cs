using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StarshipAPI.Models
{
    public class StarshipContext : DbContext
    {
        public StarshipContext(DbContextOptions<StarshipContext> options) : base(options)
        {
        }

        public DbSet<Crewmate> Crewmates { get; set; }
    }
}
