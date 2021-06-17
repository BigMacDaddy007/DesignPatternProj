using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class EnergyGeneratorModuleRoom : ModuleRoom
    {
        protected int numOfGenerators { get; set; }
        public EnergyGeneratorModuleRoom(DbContext context) : base(context)
        {
            numOfGenerators = 0;
        }

        public EnergyGeneratorModuleRoom(int numOfGenerators, DbContext context) : base(context) 
        {
            this.numOfGenerators = numOfGenerators;
        }
         
        public void addGenerator(Ship ship)
        {
            numOfGenerators++; //UNLIMITED POWER
            ship.Fuel = ship.Fuel + 50;
            _context.Update(ship);
            _context.SaveChangesAsync();
        }

        public override string display()
        {
            Console.WriteLine("these " + numOfGenerators + " energy generators have all the power we need");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}