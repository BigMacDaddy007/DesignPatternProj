using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.FinancialSectorController.Commands
{
    public class BuyModuleCommand : CommandWithDbContext, ICommandFactory
    {
        public string CommandName { get { return "BuyModuleCommand"; } }

        public string CommandDescription { get { return "Utilize credits to purchase a ship module"; } }

        public BuyModuleCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand()
        {
            return new BuyModuleCommand(this.Context);
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
