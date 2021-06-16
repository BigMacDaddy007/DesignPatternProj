using Shared.constants;
using StarshipAPI.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class ModuleUnitRoom
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public SectorType Sector { get; set; }
        public int EnergyMaintenanceCost { get; set; }
        public int ResourceMaintenanceCost { get; set; }
        public int PurchaseCost { get; set; }
        public int InstallationCost { get; set; }
        public InstallationType Type { get; set; }
        public SqlDateTime EntryDate { get; set; }
        public ICollection<ShipModuleUnitRoom> ShipModuleUnitRooms { get; set; }
    }
}
