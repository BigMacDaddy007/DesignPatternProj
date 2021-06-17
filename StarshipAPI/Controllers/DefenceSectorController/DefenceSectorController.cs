using Microsoft.AspNetCore.Mvc;
using Shared.constants;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands.Reports;
using StarshipAPI.Controllers.Common.Commands.Reports.Parameters;
using StarshipAPI.Controllers.Common.Commands.Reports.Results;
using StarshipAPI.Controllers.DefenceSectorController.Commands;
using StarshipAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.DefenceSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefenceSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private DefenceSectorCommandParser _commandParser;

        public DefenceSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new DefenceSectorCommandParser(this.getAvailableCommands());
            // this._shipConsole.getShip(string userToken/ShipIdentifier);
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new UseEnergyToRechargeShieldCommand(this._context),
                new GetSectorFinanceReport(this._context)
                //TODO: 
            };
        }

        // GET: api/defencesector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }

        [HttpGet("financereport/")]
        public IEnumerable<Finance> GetSectorFinanceReport()
        {
            var ship = new Ship();
            ship.Id = 1;
            var parameters = new ReportParams("GetSectorFinanceReport", SectorType.Mining, ship);
            var command = _commandParser.ParseCommand(parameters);
            command.Execute();
            return (command.Result as ReportResult<Finance>).Payload;
        }
    }
}
