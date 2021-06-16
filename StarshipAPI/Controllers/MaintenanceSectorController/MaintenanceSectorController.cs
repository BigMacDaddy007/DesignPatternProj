using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarshipAPI.Models;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.MaintenanceSectorController.Commands;

namespace StarshipAPI.Controllers.MaintenanceSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private MaintenanceSectorCommandParser _commandParser;

        public MaintenanceSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new MaintenanceSectorCommandParser(this.getAvailableCommands());
            // this._shipConsole.getShip(string userToken/ShipIdentifier);
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new RepairShipHullCommand(this._context)
            };
        }

        // GET: api/maintenancesector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }

    }
}
