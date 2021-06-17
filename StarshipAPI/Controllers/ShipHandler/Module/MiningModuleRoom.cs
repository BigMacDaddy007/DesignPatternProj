using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class MiningModuleRoom : ModuleRoom
    {
        protected int numOfMiners { get; set; }
        protected int mineSize { get; set; }
        
        public MiningModuleRoom(DbContext context) : base(context)
        {
            numOfMiners = 0;
        }

        public MiningModuleRoom(int mineSize, DbContext context) : base(context)
        {
            numOfMiners = 0;
            this.mineSize = mineSize;
        }

        public MiningModuleRoom(int numofMiners, int wardSize, DbContext context) : base(context)
        {
            this.numOfMiners = numOfMiners;
            this.mineSize = mineSize;
        }

        public void employMiner()
        {
            if (numOfMiners < mineSize) 
                numOfMiners++;
            else
                Console.WriteLine("this mining operation is at full capacity");
        }
        public void fireMiner() { 
            if (numOfMiners == 0) 
            Console.WriteLine("we literally have nobody employed");
            else
            numOfMiners--;
        }
        public void mine(Ship ship)
        {
            Random r = new Random();
            int randomChance = r.Next(0, 100);
            if (randomChance > 80)
            {
                Console.WriteLine("woah, big haul! We struck the gold mine boys");
                ship.Resources = ship.Resources + 5;
            }
            if (randomChance > 50)
            {
                Console.WriteLine("found some shiny space rocks");
                ship.Resources = ship.Resources + 2;
            }
            else
            {
                Console.WriteLine("nothing here. keep digging");
            }
            _context.Update(ship);
            _context.SaveChangesAsync();
        }
        public override string display()
        {
            Console.WriteLine("this mining operation has " + numOfMiners + " miners working here");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}