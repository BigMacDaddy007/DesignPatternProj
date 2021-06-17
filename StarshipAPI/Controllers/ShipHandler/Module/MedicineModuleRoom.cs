using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class MedicineModuleRoom : ModuleRoom
    {
        protected int numOfPatients { get; set; }
        protected int wardSize { get; set; }

        public MedicineModuleRoom(DbContext context) : base(context)
        {
            numOfPatients = 0;
        }

        public MedicineModuleRoom(int wardSize, DbContext context) : base(context)
        {
            numOfPatients = 0;
            this.wardSize = wardSize;
        }

        public MedicineModuleRoom(int numofPatients, int wardSize, DbContext context) : base(context)
        {
            this.numOfPatients = numOfPatients;
            this.wardSize = wardSize;
        }

        public void admitPatient(Crewmate sickCrewmate)
        {
            if (numOfPatients < wardSize) {
                Console.WriteLine("patient admitted!");
                numOfPatients++;
                sickCrewmate.Health = sickCrewmate.Health + 20;
                Console.WriteLine("patient treated and discharged!");
                numOfPatients--;
                _context.Update(sickCrewmate);
                _context.SaveChangesAsync();

            }
            else
                Console.WriteLine("this medicine room is at full capacity");
        }

        public override string display()
        {
            Console.WriteLine("this medicine room has " + numOfPatients + " spaces occupied out of " + wardSize + " available");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}