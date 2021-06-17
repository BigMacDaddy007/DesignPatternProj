using Shared.PatternsBase.Command.classes;
using StarshipAPI.Models.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.ProductionSectorController.Commands.Params
{
    public class ProductionParams : CommandExecuteParams
    {
        public EnergyCreditsResources Data { get; set; }

        public ProductionParams(string commandName, EnergyCreditsResources data) : base(commandName) 
        {
            this.Data = data;
        }
    }
}
