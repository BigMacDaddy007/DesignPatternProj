using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.ProductionSectorController
{
    public class ProductionSectorCommandParser : CommandParser
    {
        public ProductionSectorCommandParser(IEnumerable<ICommandFactory> commands) : base(commands) { }
    }
}
