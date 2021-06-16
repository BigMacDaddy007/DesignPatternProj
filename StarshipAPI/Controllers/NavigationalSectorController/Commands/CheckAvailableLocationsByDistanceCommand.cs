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
    public class CheckAvailableLocationsByDistanceCommand : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        public string CommandName { get { return "CheckAvailableLocationsByDistanceCommand"; } }

        public string CommandDescription { get { return "Check all viable destinations within a specific range"; } }

        public CommandExecuteParams Parameters { get; set; }

        public CheckAvailableLocationsByDistanceCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand()
        {
            return new CheckAvailableLocationsByDistanceCommand(this.Context);
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
