using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.MiningSectorController.Commands;
using StarshipAPI.Controllers.ShipHandler.Module;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.classes;

namespace StarshipAPI.Controllers.MiningSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiningSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private MiningSectorCommandsParser _commandParser;
        

        public MiningSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new MiningSectorCommandsParser(this.getAvailableCommands());
            // this._shipConsole.getShip(string userToken/ShipIdentifier);
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new ScanForResourcesCommand(this._context),
                new MiningExpeditionCommand(this._context),
                new RepairMiningEquipmentCommand(this._context)
            };
        }

        // GET: api/miningsector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }


        [HttpPut("gomining/{id}")]
        public async Task<ActionResult<Ship>> GoMining(int id)
        {
            MiningModuleRoom miningModuleRoom = new MiningModuleRoom(_context);
            var ship =  await _context.Ship.FindAsync(id);
            miningModuleRoom.mine(ship);
            return ship;
        }
    }
}
