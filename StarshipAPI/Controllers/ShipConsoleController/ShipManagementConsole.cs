using Microsoft.EntityFrameworkCore;
using Shared.Modules.ShipManagementConsoleModule.Models;
using Shared.PatternsBase.Command.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Modules.ShipManagementConsoleModule
{
    public class ShipManagementConsole
    {
        private DbContext _context;
        private Ship _ship;
        private CommandParser _parser;
        
        public CommandParser Parser { get { return this._parser; } }

        public ShipManagementConsole(DbContext dbContext, Ship ship, CommandParser parser)
        {
            this._context = dbContext;
            this._ship = ship;
            this._parser = parser;

            this.getUserShip();
        }

        private void getUserShip()
        {
            Console.WriteLine("Get User Ship From Db");
            Console.WriteLine("Validate if ship belongs to user");
        }

        private void getShipStats()
        {

        }
    }
}
