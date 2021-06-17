using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using StarshipAPI.Models;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class CafeteriaModuleRoom: ModuleRoom { 
        public CafeteriaModuleRoom(DbContext context) : base(context) { 
        
        }
        public void serveLunch(int dayOfWeek, Crewmate crewmate ) { 
            switch (dayOfWeek) { 
                case 1: 
                Console.WriteLine("Monday is sloppy joe day!");
                crewmate.Health = crewmate.Health + 10;
                break;
                case 2: 
                Console.WriteLine("Tuesday is chinese food day!");
                crewmate.Health = crewmate.Health + 12;
                break;
                case 3: 
                Console.WriteLine("Wednesday is spaghetti and meatballs!");
                crewmate.Health = crewmate.Health + 8;
                break;
                case 4: 
                Console.WriteLine("Thursday is mash and gravy day!");
                crewmate.Health = crewmate.Health + 5;
                break;
                case 5: 
                Console.WriteLine("Friday is braai day!");
                crewmate.Health = crewmate.Health + 40;
                break;
                case 6: 
                Console.WriteLine("Saturday is pizza day!");
                crewmate.Health = crewmate.Health + 20;
                break;
                case 7: 
                Console.WriteLine("Sunday is chicken sandwich day!");
                crewmate.Health = crewmate.Health + 15;
                break;
                default:
                Console.WriteLine("i dont know, check the bottom of the pot or something");
                crewmate.Health = crewmate.Health - 10;
                break;
            }
            _context.Update(crewmate);
            _context.SaveChangesAsync();
        }
        public override string display() { 
            Console.WriteLine("this is one fine eating establishment");
            return null;
        }

        public override void loadDbState()
        {
            throw new NotImplementedException();
        }
    }
}