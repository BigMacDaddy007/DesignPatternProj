public class MiningModuleRoom: ModuleRoom { 
    protected int numOfMiners { get; set;}
    protected int mineSize { get; set;}
    public MiningModuleRoom(int mineSize) { 
        numOfMiners = 0;
        this.mineSize = mineSize;
    }
      public MiningModuleRoom(int numofMiners, int wardSize) { 
        this.numOfMiners = numOfMiners;
        this.mineSize = mineSize;
    }

    public void employMiner() { 
        if(numOfMiners < mineSize)
        numOfMiners++;
        else
        Console.WriteLine("this mining operation is at full capacity");
    }
    public void mine() { 
        //random number generator here to make the resources go up? could feature a few more
        // of these across the ModuleRooms to have a little bit of dynamic changes to the attributes 
        Random r = new Random();
        int randomChance = r.Next(0,100);
        if(randomChance > 80) { 
            Console.WriteLine("woah, big haul! We struck the gold mine boys");
            totalResource = totalResource + 5;
        }
        if (randomChance > 50) { 
            Console.WriteLine("found some shiny space rocks");
            totalResource = totalResource + 2;
        }
        else { 
            Console.WriteLine("nothing here. keep digging");
        }
    }
    public string display() { 
        Console.WriteLine("this mining operation has " + numOfMiners + " miners working here");
    }  
}