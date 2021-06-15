public class MedicineModuleRoom: ModuleRoom { 
    protected int numOfPatients { get; set;}
    protected int wardSize { get; set;}
    public MedicineModuleRoom(int wardSize) { 
        numOfPatients = 0;
        this.wardSize = wardSize;
    }
      public MedicineModuleRoom(int numofPatients, int wardSize) { 
        this.numOfPatients = numOfPatients;
        this.wardSize = wardSize;
    }

    public void admitPatient() { 
        if(numOfPatients < wardSize)
        numOfPatients++;
        else
        Console.WriteLine("this medicine room is at full capacity");
    }
    public string display() { 
        Console.WriteLine("this medicine room has " + numOfPatients + " spaces occupied out of " + wardSize + " available");
    }

   
}