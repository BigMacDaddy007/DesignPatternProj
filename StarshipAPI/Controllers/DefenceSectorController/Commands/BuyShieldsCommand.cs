using Microsoft.EntityFrameworkCore;
using Shared.constants;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands;
using StarshipAPI.Models;
using StarshipAPI.Shared.Constants;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.DefenceSectorController.Commands
{
    public class BuyShieldsCommand : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        public string CommandName { get { return "BuyShieldsCommand"; } }

        public string CommandDescription { get { return "Utilize credits to buy shields"; } }

        public CommandExecuteParams Parameters { get; set; }

        public BuyShieldsCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
           try
           {
                //Get DB
                var ship = new Ship();
                ship.Id = 1;

                var expense = new Finance();
                expense.Request = "Buy Shield";
                expense.Sector = SectorType.Defence;
                expense.Type = FinanceType.Expense;
                expense.ShipID = ship.Id;


                var result = (this.Context as StarshipContext).Finance.Add(expense);

                (this.Context as StarshipContext).SaveChanges();
                //(this.Result as GeneralCommandResult<Finance>).Payload = new Finance[] { result.Entity };

           }
           catch
           {

           }
        }

        public ICommand MakeCommand()
        {
            return new BuyShieldsCommand(this.Context);
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
