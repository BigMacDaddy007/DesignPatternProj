using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.DefenceSectorController
{
    public class DefenceSectorCommandParser : CommandParser
    {

        public DefenceSectorCommandParser(IEnumerable<ICommandFactory> commands) : base(commands) { }
    }
}
