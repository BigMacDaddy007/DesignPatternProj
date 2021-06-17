using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.constants;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Controllers.Common.Commands.Reports.Parameters;
using StarshipAPI.Controllers.Common.Commands.Reports.Results;
using StarshipAPI.Models;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.Common.Commands.Reports

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
                if (!this.Validate() || (this.Parameters as ReportParams).ActiveShip == null)
                {
                    throw new Exception("Invalid Parameters Provided");
                }

                this.Result = new ReportResult<Finance>();

                (this.Result as ReportResult<Finance>).Payload = (IEnumerable<Finance>)GetReport((this.Parameters as ReportParams).ActiveShip);

            } catch (Exception ex)
            {
                this.Result = new ReportResult<Finance>();
                this.Result.Status = ResultStatus.FAILED;
                this.Result.Reason = ex.Message;
            }
        }

        private async Task<ActionResult<IEnumerable<Finance>>> GetReport(Ship Ship)
        {
            var report = await (this.Context as StarshipContext).Finance.Where(s => s.ShipId == Ship.Id).ToListAsync();
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
            return (Parameters.GetType() == typeof(ReportParams));
        }
    }
}
