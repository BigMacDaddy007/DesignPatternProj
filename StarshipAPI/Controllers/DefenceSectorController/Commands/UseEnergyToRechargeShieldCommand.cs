using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using StarshipAPI.Models;
using StarshipAPI.Shared.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.constants;
using StarshipAPI.Controllers.Common.Commands;

namespace StarshipAPI.Controllers.DefenceSectorController.Commands
{
    public class UseEnergyToRechargeShieldCommand : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        private const int purchaseCost = 5;
        private const int installationCost = 5;
        public string CommandName { get { return "UseEnergyToRechargeShieldCommand"; } }

        public string CommandDescription { get { return "Utilize energy to bring shields up to full strength"; } }
        public CommandExecuteParams Parameters { get; set; }

        public UseEnergyToRechargeShieldCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            
            var ship = new Ship();
            ship.Id = 1;

            var expense = new ModuleUnitRoom();
            expense.Name = "Use Energy To Recharge Shield Command";
            expense.PurchaseCost = purchaseCost;
            expense.InstallationCost = installationCost;
            expense.ShipID = ship.Id;
            this.Result = new GeneralCommandResult<ModuleUnitRoom>();
            var result = (this.Context as StarshipContext).ModuleUnitRoom.Add(expense);

            (this.Context as StarshipContext).SaveChanges();
            (this.Result as GeneralCommandResult<ModuleUnitRoom>).Payload = new ModuleUnitRoom[] { result.Entity };
        }

        public ICommand MakeCommand()
        {
            return new UseEnergyToRechargeShieldCommand(this.Context);
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
