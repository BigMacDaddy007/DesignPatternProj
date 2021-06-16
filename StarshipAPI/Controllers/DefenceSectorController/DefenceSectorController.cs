using Microsoft.AspNetCore.Mvc;
using Shared.PatternsBase.Command.interfaces;
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
                new UseEnergyToRechargeShieldCommand(this._context)
            };
        }

        // GET: api/defencesector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }
    }
}
