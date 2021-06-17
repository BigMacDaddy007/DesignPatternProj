using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.constants;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.Common.Commands

{
    public class GetSectorFinanceReport : CommandWithDbContext, ICommandFactory, ICommandParameters
    {
        public string CommandName { get { return "GetSectorFinanceReport"; } }

        public string CommandDescription { get { return "Generate the specified sectors Finance Report"; } }

        public CommandExecuteParams Parameters { get; set; }

        public GetSectorFinanceReport(DbContext context) : base(context) { }

        public override void Execute()
        {
            try
            {
                if (!this.Validate() || (this.Parameters as GeneralCommandParams).Ship == null)
                {
                    throw new Exception("Invalid Parameters Provided");
                }

                this.Result = new GeneralCommandResult<Finance>();

                (this.Result as GeneralCommandResult<Finance>).Payload = (IEnumerable<Finance>)GetReport((this.Parameters as GeneralCommandParams).Ship);

                if ((this.Result as GeneralCommandResult<Finance>).Payload == null)
                {
                    throw new Exception("Request Failed.");
                }


            } catch (Exception ex)
            {
                this.Result = new GeneralCommandResult<Finance>();
                this.Result.Status = ResultStatus.FAILED;
                this.Result.Reason = ex.Message;
                (this.Result as GeneralCommandResult<Finance>).Payload = null;
            }
        }

        private async Task<IEnumerable<Finance>> GetReport(Ship Ship)
        {
            var report = await (this.Context as StarshipContext).Finance.Where(s => s.ShipID == Ship.Id).ToListAsync();
            return report;
        }

        public ICommand MakeCommand()
        {
            return new GetSectorFinanceReport(this.Context);
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }

        public override bool Validate()
        {
            return (Parameters != null && Parameters.GetType() == typeof(GeneralCommandParams));
        }
    }
}
