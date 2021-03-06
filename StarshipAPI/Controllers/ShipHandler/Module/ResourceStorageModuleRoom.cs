using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class ResourceStorageModuleRoom : ModuleRoom
    {
        public ResourceStorageModuleRoom(DbContext context) : base(context)
        {
        }
        public void addResources(int newResources, Ship ship)
        {
            ship.Resources = ship.Resources + newResources;
            Console.WriteLine("resources have been added");
            _context.Update(ship);
            _context.SaveChangesAsync();
        }
        public void removeResources(int removedResources, Ship ship) { 
            ship.Resources = ship.Resources - removedResources;
            Console.WriteLine("resources have been removed");
            _context.Update(ship);
            _context.SaveChangesAsync();
        }
        public override string display()
        {
            Console.WriteLine("we have resources, we hope");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}