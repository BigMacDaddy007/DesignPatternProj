using Shared.constants;
using StarshipAPI.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace StarshipAPI.Models
{
    public class Finance
    {
        public int Id { get; set; }
        public FinanceType Type { get; set; }
        public string Request { get; set; }
        public int Value { get; set; }
        public SectorType Sector { get; set; }

        [ForeignKey("Ship")]
        public long ShipID { get; set; }
    }
}
