using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class Ship
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public double EfficienyScore { get; set; }

        public int TotalEnergyCost { get; set; }

        public int  FuelExpenditure { get; set; }

        public int TotalResource { get; set; }

        public int ResourceExpenditure { get; set; }
        public bool Active { get; set; }
        public SqlDateTime EntryDate { get; set; }

        public ICollection<ShipOperator> ShipOperators { get; set; }
        public ICollection<Finance> Finances { get; set; }
        public ICollection<ShipModuleUnitRoom> ShipModulesUnitsRooms { get; set; }
    }
}
