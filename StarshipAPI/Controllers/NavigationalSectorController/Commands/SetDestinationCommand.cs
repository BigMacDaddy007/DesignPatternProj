using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.NavigationalSectorController.Commands
{
    public class SetDestinationCommand : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        public string CommandName { get { return "SetDestinationCommand"; } }

        public string CommandDescription { get { return "Set Ships Travel Destination"; } }

        public SetDestinationCommand(DbContext context) : base(context) { }
        public CommandExecuteParams Parameters { get; set; }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand()
        {
            return new SetDestinationCommand(this.Context);
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
