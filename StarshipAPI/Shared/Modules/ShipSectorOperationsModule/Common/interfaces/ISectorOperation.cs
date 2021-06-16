using Shared.constants;
using Shared.PatternsBase.ChainOfResponsibility.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.ShipSectors.Operations.Common.interfaces
{
    interface ISectorOperation : IOperation
    {
        public SectorType Sector { get; } 
    }
}
