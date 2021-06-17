using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Shared.PatternsBase.Command.interfaces
{
    public interface ICommandParameters
    {
        public CommandExecuteParams Parameters { get; set; }
    }
}
