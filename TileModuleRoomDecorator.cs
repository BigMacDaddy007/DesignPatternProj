public class TileModuleRoomDecorator: ModuleRoomDecorator { 
    protected ModuleRoom moduleRoom;
    public TileModuleRoomDecorator(ModuleRoom moduleRoom) { 
        this.moduleRoom = moduleRoom;
    }
    public void tileRoom() { 
        Console.WriteLine("Floor of module room" + moduleID + " has been tiled!");
    }
    public void removeTiles() { 
        Console.WriteLine("The floor of " + moduleID + " is lava!");
    }
}