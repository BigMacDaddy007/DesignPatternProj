using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class Crewmate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Shields { get; set; }
        public int ShieldRegen { get; set; }
        public int Speed { get; set; }
    }
}
