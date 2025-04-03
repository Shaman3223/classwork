namespace FirstProj1;
// everything in C# in defined in a class

struct Room
{
    public string nameOfRoom;
    public string descriptionOfRoom;
    public Dictionary<string,Action> observables;

    void printDescription()
    {
        Console.WriteLine(descriptionOfRoom);
    }

    public Room(string name, string description, Dictionary<string,Action> keys)
    {
        nameOfRoom = name;
        descriptionOfRoom = description;
        observables = keys;
    }

}

struct RoomMap
{
    public Room[][] mapOfRooms;
    public int width;
    public int height;

    public RoomMap(Room[][] mapOfRooms)
    {
        this.mapOfRooms = mapOfRooms;
        width = mapOfRooms[0].Length;
        height = mapOfRooms.Length;
    }

    public Room getRoom(int x, int y)
    {
        return mapOfRooms[y][x];
    }
}

class Rooms
{
    public static string[] Inventory = [];
    
    public Room lab = new Room("The Lab",
        """
        Its cold, it smells like gass in here. 
        Theres a metal table in front of me with some tools. To the right is a hard glass box with a key",
        """,
        new Dictionary<string, Action>
        {
            {"table", () => { 
                Console.WriteLine("The table is a table.");
                if (!Inventory.Contains("hammer"))
                {
                    Inventory.Append("hammer");
                } 
            } },
            {"tools", () => { Console.WriteLine("There is bunch of medical tools here, a scalpel, a hammer and a small box."); } },
            {"hammer", () => { Console.WriteLine("Ive picked up the hammer!"); } }
                
        }
    );
    public Room hall = new Room("The Hallway",
        """
        Its even colder out here in the hallway.
        Theres a metal table in front of me with some tools. To the right is a hard glass box with a key
        """,
        new Dictionary<string, Action>
        {
            {"table", () => { Console.WriteLine("The table is a table."); } },
            {"tools", () => { Console.WriteLine("There is bunch of medical tools here, a scalpel, a hammer and a small box."); } },
            {"hammer", () => { Console.WriteLine("Ive picked up the hammer!"); } }
                
        }
    );
}
    


class Program
{
    // A class is an object in coding
    static void Main(string[] args)
    {
        var RCI = new Rooms(); //ROOMS CLASS INSTANCE

        //This is a function named Main that performs on its own at the beginning.
        Console.WriteLine("--- Starting Program ---");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine(RCI.lab.descriptionOfRoom);
            Console.WriteLine("Inventory: ");
            foreach (var item in Rooms.Inventory)
            {
                Console.WriteLine($"- {item}");
            }
            
            string input = Console.ReadLine();

            foreach (var items in RCI.lab.observables)
            {
                if (input == items.Key)
                {
                    items.Value.Invoke();
                }
            }

        }
        
        Console.WriteLine("--- Ending Program  ---");
    }
}