using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.ProcessingSectorController.Commands
{
    public class ConvertEnergyAndResourceToFuelCommand : CommandWithDbContext, ICommandFactory
    {
        public string CommandName { get { return "ConvertEnergyAndResourceToFuelCommand"; } }

        public string CommandDescription { get { return "Convert Energy and Resources into Fuel"; } }

        public ConvertEnergyAndResourceToFuelCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand(CommandExecuteParams arguments)
        {
            return new ConvertEnergyAndResourceToFuelCommand(this.Context);
        }

        public override void Validate()
        {
            Console.WriteLine("Run Validation Against Params or Data in DB");
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
