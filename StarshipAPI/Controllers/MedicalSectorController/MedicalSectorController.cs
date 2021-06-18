using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.MedicalSectorController.Commands;
using StarshipAPI.Controllers.ShipHandler.Module;
using StarshipAPI.Models;

namespace StarshipAPI.Controllers.MedicalSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalSectorController : ControllerBase
    {
        private readonly StarshipContext _context;
        private MedicalSectorCommandParser _commandParser;

        public MedicalSectorController(StarshipContext context)
        {
            this._context = context;
            this._commandParser = new MedicalSectorCommandParser(this.getAvailableCommands());
        }

        private IEnumerable<ICommandFactory> getAvailableCommands()
        {
            return new ICommandFactory[] {
                new RunMedicalTestsCommand(this._context),
                new VaccinateCrewCommand(this._context)
            };
        }

        // GET: api/medicalsector/
        [HttpGet]
        public ActionResult<IEnumerable<ICommandFactory>> GetAvailableMiningCommands()
        {
            return this._commandParser.GetAvailabelCommands().ToList();
        }
        [HttpPut("admitpatient/{id}")]
        public async Task<ActionResult<Crewmate>> admitPatient(int id)
        {
            MedicineModuleRoom medicineModuleRoom = new MedicineModuleRoom(_context);
            var crewmate = await _context.Crewmate.FindAsync(id);
            medicineModuleRoom.admitPatient(crewmate);
            return crewmate;
        }
    }
}
