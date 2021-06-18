using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
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
    }
}
