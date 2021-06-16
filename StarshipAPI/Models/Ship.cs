using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class Ship
    {
        public string name { get; set; }
        public long ID { get; set; }

        public double efficienyScore { get; set; }

        public int totalEnergyCost { get; set; }

        public int  fuelExpenditure { get; set; }

        public int totalResource { get; set; }

        public int resourceExpenditure { get; set; }
    }
}
