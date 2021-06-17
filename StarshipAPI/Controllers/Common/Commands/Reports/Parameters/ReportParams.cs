using Shared.constants;
using Shared.PatternsBase.Command.classes;
using StarshipAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.Common.Commands.Reports.Parameters
{
    public class ReportParams : CommandExecuteParams
    {
        SectorType _sector;
        Ship _ship;

        public SectorType Sector { get; }

        public Ship ActiveShip { get; }

        public ReportParams(string commandName, SectorType sector, Ship ship) : base(commandName)
        {
            this._sector = sector;
            this._ship = ship;
        }
    }
}
