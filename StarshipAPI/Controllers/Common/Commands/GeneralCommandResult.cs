using Shared.constants;
using StarshipAPI.Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.Common.Commands
{
    public class GeneralCommandResult <T> : ICommandResult
    {
        public string StatusDescription { get { return Enum.GetName(typeof(ResultStatus), Status); } }
        public ResultStatus Status { get; set; }
        public string Reason { get; set; }
        public IEnumerable<T> Payload { get; set; }

        public GeneralCommandResult() { }
    }
}
