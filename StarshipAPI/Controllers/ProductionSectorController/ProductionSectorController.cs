using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.ProductionSectorController.Commands;
using StarshipAPI.Controllers.ShipHandler.Module;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.classes;

namespace StarshipAPI.Controllers.ProductionSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private ProductionSectorCommandParser _commandParser;

        public ProductionSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new ProductionSectorCommandParser(this.getAvailableCommands());
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new ConvertEnergyAndResourceToFuelCommand(this._context),
                new ConvertResourceToEnergyCommand(this._context)
            };
        }

        // GET: api/productionsector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }
        
        [HttpPut("harvestfarm/{id}")]
        public async Task<ActionResult<Ship>> harvestFarm(int id)
        {
            FarmingModuleRoom farmingModuleRoom = new FarmingModuleRoom(_context);
            var ship = await _context.Ship.FindAsync(id);
            farmingModuleRoom.harvest(ship);
            return ship;
        }
    }
}
