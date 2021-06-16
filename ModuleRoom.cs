public abstract class ModuleRoom { 

    public int fuelExpenditure;
    public int totalFuel;
    public float efficiencyScore;
    public string name {get; set;}
    public int totalResource;
    public int totalEnergyCost;
    public int resourceExpenditure;
    public bool isTiled { get; set; }
    public bool ceilingPainted { get; set; }
    public bool hasWindows {get; set;}

public ModuleRoom() { 
    isTiled = false;
    ceilingPainted = false;
    hasWindows = false;
}
protected string moduleID {
    set;
    get;
}
    public int getFuelExpenditure() { return fuelExpenditure;}
    public int getEnergyExpenditure() { return totalEnergyCost;}
    public int getResourceExpenditure() {return resourceExpenditure;}

    public int getTotalEnergyGenerated() {return totalResource;}
public abstract string display();
}