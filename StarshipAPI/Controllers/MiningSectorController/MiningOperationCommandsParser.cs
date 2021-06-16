using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.MiningSectorController
{
    public class MiningOperationCommandsParser : CommandParser
    {

        public MiningOperationCommandsParser(IEnumerable<ICommandFactory> commands): base(commands) { }
    }
}
