public class ShipModuleRoomDecorator: ModuleRoomDecorator { 
    protected ModuleRoom moduleRoom;
    //insert Ship variable here
    public ShipModuleRoomDecorator(ModuleRoom moduleRoom) { 
        this.moduleRoom = moduleRoom;
    }
    public int Name { get; set;}
    public int getFuelExpenditure() { return moduleRoom.getFuelExpenditure(); }
    public int getEnergyExpenditure() { return moduleRoom.getEnergyExpenditure(); }
    public int getResourceExpenditure() { return moduleRoom.getResourceExpenditure(); }
    public int getTotalEnergyGenerated() { return moduleRoom.getTotalEnergyGenerated(); }
}