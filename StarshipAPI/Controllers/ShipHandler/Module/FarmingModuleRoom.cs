using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class FarmingModuleRoom : ModuleRoom
    {
        protected int numOfFarmers { get; set; }
        protected int farmSize { get; set; }
        protected string cropPlanted { get; set; }
        public FarmingModuleRoom(DbContext context) : base(context)
        {
            numOfFarmers = 0;
            _context = context;
        }
        public FarmingModuleRoom(int farmSize, DbContext context) : base(context)
        {
            this.numOfFarmers = 0;
            this.farmSize = farmSize;
            cropPlanted = "corn";
            _context = context;
        }
        public FarmingModuleRoom(int numOfFarmers, int farmSize, DbContext context) : base(context)
        {
            this.numOfFarmers = numOfFarmers;
            this.farmSize = farmSize;
            cropPlanted = "corn";
            _context = context;
        }
        public FarmingModuleRoom(int numOfFarmers, int farmSize, string cropPlanted, DbContext context) : base(context)
        {
            this.numOfFarmers = numOfFarmers;
            this.farmSize = farmSize;
            this.cropPlanted = cropPlanted;
            _context = context;
        }


        public void addFarmer()
        {
            if (numOfFarmers < farmSize)
                numOfFarmers++;
            else
                Console.WriteLine("this farm has too many hands");
        }
        public void fireFarmer() {
            if(numOfFarmers == 0)
            Console.WriteLine("we got no farmers");
            else
            numOfFarmers--;
        }
        public void harvest(Ship ship)
        {
            Console.WriteLine("harvesting all the " + cropPlanted);
            ship.Resources = ship.Resources + 20;
            _context.Update(ship);
            _context.SaveChangesAsync();
        }
        public void plant(Ship ship)
        {
            Console.WriteLine("planting all the " + cropPlanted + " seeds");
            ship.Resources = ship.Resources - 5;
             _context.Update(ship);
            _context.SaveChangesAsync();
        }
        public override string display()
        {
            Console.WriteLine("this farm has " + numOfFarmers + " out of the " + farmSize + " it can occupy");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}