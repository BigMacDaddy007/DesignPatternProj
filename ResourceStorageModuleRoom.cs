public class ResourceStorageModuleRoom: ModuleRoom { 
    public ResourceStorageModuleRoom() { 
    }
      public ResourceStorageModuleRoom(int numOfResources) { 
        this.totalResource = numOfResources;
    }

    public void addResources(int newResources) { 
        totalResource = totalResource + newResources;
        Console.WriteLine("resources have been added");
    }
    public string display() { 
        Console.WriteLine("we have " + totalResource + " amount of resources");
    }  
}