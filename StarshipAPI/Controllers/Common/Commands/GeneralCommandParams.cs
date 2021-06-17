using Shared.constants;
using Shared.PatternsBase.Command.classes;
using StarshipAPI.Models;
using StarshipAPI.Models.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StarshipAPI.Controllers.Common.Commands
{
    public class GeneralCommandParams : CommandExecuteParams
    {
        public Ship Ship { get; set; }
        public SectorType Sector { get; set; }
        public EnergyCreditsResources Data {get; set;}

        public GeneralCommandParams(string commandName) : base(commandName) { }
    }
}
