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
            var parameters = (this.Parameters as GeneralCommandParams);
            var results = new GeneralCommandResult<Finance>();
            try
            {
                if (!this.Validate() || (this.Parameters as GeneralCommandParams).Ship == null)
                {
                    throw new Exception("Invalid Parameters Provided");
                }

                results.Payload = GetReport(parameters.Ship).Result;

                if (results.Payload == null)
                {
                    throw new Exception("Request Failed.");
                }

                results.Status = ResultStatus.SUCCESS;
                results.Reason = "Request Successful";
                this.Result = results;

            } 
            catch (Exception ex)
            {
                results.Status = ResultStatus.FAILED;
                results.Reason = ex.Message;
                results.Payload = null;
                this.Result = results;
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
