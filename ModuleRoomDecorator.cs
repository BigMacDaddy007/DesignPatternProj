public class ModuleRoomDecorator {   
  protected ModuleRoom moduleRoom;
  
  public ModuleRoomDecorator(ModuleRoom moduleRoom, string name) {
    this.moduleRoom = moduleRoom;
    this.moduleRoom.moduleID = name;
    }
  public void tileRoom() { 
    if(!moduleRoom.isTiled) { 
        Console.WriteLine("Floor of module room" + moduleRoom.moduleID + " has been tiled!");
        moduleRoom.isTiled = true;
    }
    else { 
      Console.WriteLine("what are we gonna do with all these extra tiles??");
    }
  }
  public void removeTiles() { 
    if(moduleRoom.isTiled) { 
        Console.WriteLine("The floor of " + moduleRoom.moduleID + " is lava!");
        moduleRoom.isTiled = false;
    }
    else { 
      Console.WriteLine("there are no tiles to remove");
    }
  }
  public void paintCeiling() { 
    if(!moduleRoom.ceilingPainted) { 
      Console.WriteLine("Ceiling of module room " + moduleRoom.moduleID + " has been painted!");
      moduleRoom.ceilingPainted = true;
    }
    else { 
      Console.WriteLine("why are you painting a ceiling again you madman");
    }
    }
  public void unPaintCeiling() { 
    if(moduleRoom.ceilingPainted) {
      Console.WriteLine("Ceiling of module room " + moduleRoom.moduleID + " is not painted anymore!");
      moduleRoom.ceilingPainted = false;
      }
    else { 
      Console.WriteLine("there is no paint to remove, plz paint the ceiling it's dark");
      }
  }
  public void addWindows() { 
    if(!moduleRoom.hasWindows) { 
      Console.WriteLine("Windows of module room " + moduleRoom.moduleID + " has been installed!");
      moduleRoom.hasWindows = true;
    }
    else { 
      Console.WriteLine("we already have windows please no more Windows updates.");
    }
  }
  public void removeWindows() { 
    if(moduleRoom.hasWindows) { 
      Console.WriteLine("Windows of module room " + moduleRoom.moduleID + " has been removed!");
      moduleRoom.hasWindows = false;
    }
    else { 
      Console.WriteLine("There are no windows to remove, we serve the Linux empire");
    }
  }
  public string display() { 
    if(moduleRoom.isTiled)
    Console.WriteLine("this room has a tiled floor");
    if(moduleRoom.ceilingPainted)
    Console.WriteLine("this room has a painted ceiling");
  }
}