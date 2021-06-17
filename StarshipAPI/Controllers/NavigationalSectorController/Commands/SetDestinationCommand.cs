using Microsoft.EntityFrameworkCore;
using Shared.constants;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands;
using StarshipAPI.Models;
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
            Context.Update((this.Parameters as GeneralCommandParams).Ship);
            Context.SaveChanges();
            this.Result = new GeneralCommandResult<Ship>();
            (this.Result as GeneralCommandResult<Ship>).Payload = new Ship[] { (this.Parameters as GeneralCommandParams).Ship };
            (this.Result as GeneralCommandResult<Ship>).Status = ResultStatus.SUCCESS;
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
