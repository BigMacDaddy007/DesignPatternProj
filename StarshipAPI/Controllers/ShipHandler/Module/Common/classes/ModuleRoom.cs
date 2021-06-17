using Microsoft.EntityFrameworkCore;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module.Common.classes
{
    public abstract class ModuleRoom
    {
        private DbContext _context;
        public int fuelExpenditure;
        public int totalFuel;
        public float efficiencyScore;
        public string name { get; set; }
        public int totalResource;
        public int totalEnergyCost;
        public int resourceExpenditure;
        public bool isTiled { get; set; }
        public bool ceilingPainted { get; set; }
        public bool hasWindows { get; set; }
        public DbContext Context { get; set; }

        public ModuleRoom(DbContext db)
        {
            _context = db;
            isTiled = false;
            ceilingPainted = false;
            hasWindows = false;
        }

        public string moduleID { set; get; }
        public int getFuelExpenditure() { return fuelExpenditure; }
        public int getEnergyExpenditure() { return totalEnergyCost; }
        public int getResourceExpenditure() { return resourceExpenditure; }

        public int getTotalEnergyGenerated() { return totalResource; }
        public abstract string display();

        public abstract void loadDbState();
    }
}