using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.FinancialSectorController.Commands;
using StarshipAPI.Models;

namespace StarshipAPI.Controllers.FinancialSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private FinancialSectorCommandParser _commandParser;

        public FinancialSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new FinancialSectorCommandParser(this.getAvailableCommands());
            // this._shipConsole.getShip(string userToken/ShipIdentifier);
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new BuyModuleCommand(this._context),
                new CreateRoomCommand(this._context)
            };
        }

        // GET: api/financialsector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }

        
    }
}
