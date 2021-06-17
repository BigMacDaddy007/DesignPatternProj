using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class ShipSectorManager
    {
        public int Id { get; set; }

        [ForeignKey("Ship")]
        public int ShipId { get; set; }

        [ForeignKey("SectorManager")]
        public int SectorManagerId { get; set; }
    }
}
