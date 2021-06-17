using StarshipAPI.Controllers.ShipConsoleController.Ship.Modules.Common.classes;
using System;

namespace StarshipAPI.Controllers.ShipConsoleController.Ship.Modules
{
    public class ResourceStorageModuleRoom : ModuleRoom
    {
        public ResourceStorageModuleRoom()
        {
        }
        public ResourceStorageModuleRoom(int numOfResources)
        {
            this.totalResource = numOfResources;
        }

        public void addResources(int newResources)
        {
            totalResource = totalResource + newResources;
            Console.WriteLine("resources have been added");
        }
        public override string display()
        {
            Console.WriteLine("we have " + totalResource + " amount of resources");
            return null;
        }
    }
}