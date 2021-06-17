using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands;
using StarshipAPI.Controllers.NavigationalSectorController.Commands;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.classes;

namespace StarshipAPI.Controllers.NavigationalSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationalSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private NavigationalSectorCommandParser _commandParser;

        public NavigationalSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new NavigationalSectorCommandParser(this.getAvailableCommands());
            // this._shipConsole.getShip(string userToken/ShipIdentifier);
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new CheckAvailableLocationsByDistanceCommand(this._context),
                new ScanCurrentLocation(this._context),
                new SetDestinationCommand(this._context)
            };
        }

        // GET: api/naviagtionalsector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }
        [HttpPut("setdestinationcommand/{id}")]
        public async Task<ActionResult<GeneralCommandResult<Ship>>> ChangeLocation(int id)
        {
            try
            {
                var ship = await _context.Ship.FindAsync(1);
                var locationId =  _context.Location.Find(id);
                             
                ship.LocationID = locationId.ID;
                var parameters = new GeneralCommandParams("SetDestinationCommand");
                parameters.Ship = ship;
                var command = _commandParser.ParseCommand(parameters);
                (command as SetDestinationCommand).Parameters = parameters;
                command.Execute();
                return (command.Result as GeneralCommandResult<Ship>);
            }
            catch
            {
                var ship = await _context.Ship.FindAsync(1);
                return new GeneralCommandResult<Ship>();
            }
            
        }
    }

}

