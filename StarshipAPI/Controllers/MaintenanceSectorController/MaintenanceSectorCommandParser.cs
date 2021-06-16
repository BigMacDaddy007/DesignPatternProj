using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.MaintenanceSectorController
{
    public class MaintenanceSectorCommandParser : CommandParser
    {
        public MaintenanceSectorCommandParser(IEnumerable<ICommandFactory> commands) : base(commands) { }
    }
}
