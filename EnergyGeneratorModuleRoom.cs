public class EnergyGeneratorModuleRoom: ModuleRoom { 
    protected int numOfGenerators { get; set;}
    public EnergyGeneratorModuleRoom() { 
        numOfGenerators = 0;
    }
      public EnergyGeneratorModuleRoom(int numOfGenerators) { 
        this.numOfGenerators = numOfGenerators;
    }

    public void addGenerator() { 
        numOfGenerators++; //UNLIMITED POWER
    }
    public string display() { 
        Console.WriteLine("these " + numOfGenerators + " energy generators have all the power we need");
    }  
}