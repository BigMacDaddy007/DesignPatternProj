using Shared.PatternsBase.ChainOfResponsibility.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.ShipSectors.Operations.Common.classes
{
    public abstract class Operator
    {
        float EfficiencyScore { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int OperationDuration { get; set; }
        int OperationCostLimit { get; set; }
        int ResourceCost { get; set; }
        int EnergyCost { get; set; }
        int CreditCost { get; set; }
    }
}
