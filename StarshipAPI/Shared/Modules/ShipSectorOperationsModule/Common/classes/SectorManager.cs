using Shared.PatternsBase.ChainOfResponsibility.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.ShipSectors.Operations.Common.classes
{
    public abstract class SectorManager
    {
        private Operator _sectorManager;

        public Operator Manager { get { return this._sectorManager; } }

        float EfficiencyScore { get; }

        SectorManager(Operator manager)
        {
            this._sectorManager = manager;
        }

        public abstract IOperationResult ProcessSectorOperation(IOperation operation);
    }
}
