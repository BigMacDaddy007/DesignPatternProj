using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class FarmingModuleRoom : ModuleRoom
    {
        protected int numOfFarmers { get; set; }
        protected int farmSize { get; set; }
        protected string cropPlanted { get; set; }
        public FarmingModuleRoom()
        {
            numOfFarmers = 0;
        }
        public FarmingModuleRoom(int farmSize)
        {
            this.numOfFarmers = 0;
            this.farmSize = farmSize;
            cropPlanted = "corn";
        }
        public FarmingModuleRoom(int numOfFarmers, int farmSize)
        {
            this.numOfFarmers = numOfFarmers;
            this.farmSize = farmSize;
            cropPlanted = "corn";
        }
        public FarmingModuleRoom(int numOfFarmers, int farmSize, string cropPlanted)
        {
            this.numOfFarmers = numOfFarmers;
            this.farmSize = farmSize;
            this.cropPlanted = cropPlanted;
        }


        public void addFarmer()
        {
            if (numOfFarmers < farmSize)
                numOfFarmers++;
            else
                Console.WriteLine("this farm has too many hands");
        }
        public void harvest()
        {
            Console.WriteLine("harvesting all the " + cropPlanted);
            totalResource = totalResource + 20;
        }
        public void plant()
        {
            Console.WriteLine("planting all the " + cropPlanted + " seeds");
            totalResource = totalResource - 5;
        }
        public override string display()
        {
            Console.WriteLine("this farm has " + numOfFarmers + " out of the " + farmSize + " it can occupy");
            return null;
        }
    }
}