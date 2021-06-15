public class CeilingModuleRoomDecorator: ModuleRoomDecorator { 
    protected ModuleRoom moduleRoom;
    public CeilingModuleRoomDecorator(ModuleRoom moduleRoom) { 
        this.moduleRoom = moduleRoom;
    }
    public void paintCeiling() { 
        Console.WriteLine("Ceiling of module room" + moduleID + " has been painted!");
    }
    public void removeCeiling() { 
        Console.WriteLine("Ceiling of module room" + moduleID + " is floating in space!");
    }
}