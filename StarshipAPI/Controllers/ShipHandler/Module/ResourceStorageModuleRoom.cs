using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class ResourceStorageModuleRoom : ModuleRoom
    {
        public ResourceStorageModuleRoom(DbContext context) : base(context)
        {
        }
        public ResourceStorageModuleRoom(int numOfResources, DbContext context) : base(context)
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

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}