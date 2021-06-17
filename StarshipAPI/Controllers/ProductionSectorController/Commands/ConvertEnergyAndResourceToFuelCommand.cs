using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.ProductionSectorController.Commands.Params;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.ProductionSectorController.Commands
{
    public class ConvertEnergyAndResourceToFuelCommand : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        public string CommandName { get { return "ConvertEnergyAndResourceToFuelCommand"; } }

        public string CommandDescription { get { return "Convert Energy and Resources into Fuel"; } }
        public CommandExecuteParams Parameters { get; set; }

        public ConvertEnergyAndResourceToFuelCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand()
        {
            return new ConvertEnergyAndResourceToFuelCommand(this.Context);
        }

        public override bool Validate()
        {
            Console.WriteLine("Run Validation Against Params or Data in DB");
            return true;
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
