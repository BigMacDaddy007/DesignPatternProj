using Microsoft.AspNetCore.Mvc;
using Shared.constants;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands;
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
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new UseEnergyToRechargeShieldCommand(this._context),
                new GetSectorFinanceReport(this._context),
                new BuyShieldsCommand(this._context)

            };
        }

        // GET: api/defencesector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableDefenceCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }

        [HttpPost("command/")]
        public IEnumerable<Finance> GetSectorFinanceReport(GeneralCommandParams obj)
        {
            var ship = new Ship();
            ship.Id = 1;

            var command = _commandParser.ParseCommand(obj);
            (command as GetSectorFinanceReport).Parameters =  obj;
            command.Execute();
            return (command.Result as GeneralCommandResult<Finance>).Payload;
        }

        [HttpGet("buyshields/")]
        public ActionResult<Finance> BuyShields()
        {

            var parameters = new GeneralCommandParams("BuyShieldsCommand");
            var command = _commandParser.ParseCommand(parameters);

            (command as BuyShieldsCommand).Parameters = parameters;
            command.Execute();
            return (command.Result as GeneralCommandResult<Finance>).Payload.FirstOrDefault();
        }
        [HttpGet("useenergyforshields/")]
        public ActionResult<ModuleUnitRoom> UseEnergyToRechargeShieldCommand()
        {

        [HttpGet("report/finance/")]
        public ActionResult<GeneralCommandResult<Finance>> GenerateReport()
        {
             var ship = new Ship();
            ship.Id = 1;

            var parameters = new GeneralCommandParams("GetSectorFinanceReport");
            parameters.Sector = SectorType.Defence;
            parameters.Ship = ship;
            var command = _commandParser.ParseCommand(parameters);

            (command as GetSectorFinanceReport).Parameters = parameters;
            command.Execute();
            return (command.Result as GeneralCommandResult<Finance>);
        }

    }


}
