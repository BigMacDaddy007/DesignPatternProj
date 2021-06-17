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

        public int Active { get; set; }

        public int LocationID { get; set; }

    }
}
