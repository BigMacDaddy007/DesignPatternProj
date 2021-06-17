using Shared.constants;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class SectorManager
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int ResourcePerk { get; set; }
        public int EnergyPerk { get; set; }
        public SectorType Sector { get; set; }

        public ICollection<ShipSectorManager> ShipSectorManagers { get; set; }
    }
}
