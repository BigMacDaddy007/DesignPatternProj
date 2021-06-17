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
        public long Id { get; set; }

        [ForeignKey("Ship")]
        public long ShipId { get; set; }

        [ForeignKey("ModuleUnitRoom")]
        public long ModuleUnitRoomId { get; set; }
    }
}
