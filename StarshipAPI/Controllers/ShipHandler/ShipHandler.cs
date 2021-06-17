using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using Microsoft.EntityFrameworkCore;
using StarshipAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarshipAPI.Controllers.ShipHandler.Module;

namespace StarshipAPI.Controllers.ShipHandler
{
    public class ShipHandler
    {
        private readonly IEnumerable<ModuleRoom> _shipModules;
        private DbContext _context;

        public ShipHandler(DbContext db)
        {
            this._context = db;
            this._shipModules = this.GetAvailableModules();
        }

        public void AddModule(ModuleRoom module)
        {
            this._shipModules.Append(module);
        }
        
        public IEnumerable<ModuleRoom> GetAvailableModules()
        {
            return new ModuleRoom[] {
                new CafeteriaModuleRoom(),
            };
        }
    }

}
