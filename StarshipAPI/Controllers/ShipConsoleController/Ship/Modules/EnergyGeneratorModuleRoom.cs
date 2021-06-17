using StarshipAPI.Controllers.ShipConsoleController.Ship.Modules.Common.classes;
using System;

namespace StarshipAPI.Controllers.ShipConsoleController.Ship.Modules
{
    public class EnergyGeneratorModuleRoom : ModuleRoom
    {
        protected int numOfGenerators { get; set; }
        public EnergyGeneratorModuleRoom()
        {
            numOfGenerators = 0;
        }
        public EnergyGeneratorModuleRoom(int numOfGenerators)
        {
            this.numOfGenerators = numOfGenerators;
        }

        public void addGenerator()
        {
            numOfGenerators++; //UNLIMITED POWER
        }
        public override string display()
        {
            Console.WriteLine("these " + numOfGenerators + " energy generators have all the power we need");
            return null;
        }
    }
}