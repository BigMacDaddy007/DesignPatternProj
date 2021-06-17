using Shared.constants;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.Common.Commands.Reports.Results
{
    public class ReportResult <T> : ICommandResult
    {
        public ResultStatus Status { get; set; }
        public string Reason { get; set; }
        public IEnumerable<T> Payload { get; set; }

        public ReportResult() { }
    }
}
