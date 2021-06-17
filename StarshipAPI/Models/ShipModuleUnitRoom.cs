using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class ShipModuleUnitRoom
    {
        public int Id { get; set; }

        [ForeignKey("Ship")]
        public int ShipId { get; set; }

        [ForeignKey("ModuleUnitRoom")]
        public int ModuleUnitRoomId { get; set; }
    }
}
