using Microsoft.EntityFrameworkCore;
using StarshipAPI.Controllers.ShipHandler.Module.Common.classes;
using System;

namespace StarshipAPI.Controllers.ShipHandler.Module
{
    public class CafeteriaModuleRoom: ModuleRoom { 
    
        public CafeteriaModuleRoom(DbContext context) : base(context) { 
        
        }
        public void serveLunch(int dayOfWeek ) { 
            switch (dayOfWeek) { 
                case 1: 
                Console.WriteLine("Monday is sloppy joe day!");
                break;
                case 2: 
                Console.WriteLine("Tuesday is chinese food day!");
                break;
                case 3: 
                Console.WriteLine("Wednesday is spaghetti and meatballs!");
                break;
                case 4: 
                Console.WriteLine("Thursday is mash and gravy day!");
                break;
                case 5: 
                Console.WriteLine("Friday is braai day!");
                break;
                case 6: 
                Console.WriteLine("Saturday is pizza day!");
                break;
                case 7: 
                Console.WriteLine("Sunday is chicken sandwich day!");
                break;
                default:
                Console.WriteLine("i dont know, check the bottom of the pot or something");
                break;
            }
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