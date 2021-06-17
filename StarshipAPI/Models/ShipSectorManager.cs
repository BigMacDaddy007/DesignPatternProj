using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class ShipSectorManager
    {
        public long Id { get; set; }

        [ForeignKey("Ship")]
        public long ShipId { get; set; }

        [ForeignKey("SectorManager")]
        public long SectorManagerId { get; set; }
    }
}
