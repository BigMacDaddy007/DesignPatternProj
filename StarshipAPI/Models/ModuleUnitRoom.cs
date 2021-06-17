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
        public int Id { get; set; }
        public string Name { get; set; }
        public SectorType SectorType { get; set; }
        public int EnergyMaintenanceCost { get; set; }
        public int ResourceMaintenanceCost { get; set; }
        public int PurchaseCost { get; set; }
        public int InstallationCost { get; set; }

        public int ShipID { get; set; }
    }
}
