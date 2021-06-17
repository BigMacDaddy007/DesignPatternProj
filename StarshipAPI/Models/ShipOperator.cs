using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Models
{
    public class ShipOperator
    {
        public long Id { get; set; }

        [ForeignKey("Ship")]
        public long ShipId { get; set; }

        [ForeignKey("Operator")]
        public long OperatorId { get; set; }
    }
}
