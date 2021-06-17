using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using StarshipAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Modules.ShipManagementConsoleModule
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipManagementConsole : ControllerBase
    {
        private DbContext _context;
        
        public ShipManagementConsole(DbContext dbContext)
        {
            this._context = dbContext;
        }

    }
}
