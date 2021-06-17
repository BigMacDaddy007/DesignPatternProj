using Shared.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.PatternsBase.Command.interfaces
{
    public interface ICommandResult
    {
        public ResultStatus Status { get; set; } 
        public string Reason { get; set; }
    }
}
