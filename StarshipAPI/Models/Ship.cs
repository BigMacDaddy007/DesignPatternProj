using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class Ship
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Energy { get; set; }

        public int  Fuel { get; set; }

        public int Resources { get; set; }

        public bool Active { get; set; }

        public ICollection<ShipSectorManager> ShipSectorManagers { get; set; }
        //public ICollection<Finance> Finances { get; set; }
        public ICollection<ShipModuleUnitRoom> ShipModulesUnitsRooms { get; set; }
    }
}
