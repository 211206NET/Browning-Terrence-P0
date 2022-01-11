using Models;
using StoreDL;
namespace StoreUI;

public class StoreManager {
    private StaticStorage _SFBL;  
    public StoreManager() 
    {
        _SFBL = new StaticStorage();
    }
    public void StartManager()
    {

    bool exit = false;

    while(!exit)
    {
        Console.WriteLine("[1] Make a Store");
        Console.WriteLine("[2] View List of Stores");
        Console.WriteLine("[x] Back to MainMenu");
        String ManagerInput = Console.ReadLine();

        switch(ManagerInput) {

            case "1":
                Console.WriteLine("\n==Add Store below==");  
                Console.WriteLine("Name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("\nAddress: ");
                string Address = Console.ReadLine();
                
                // Store newStore = new Store();  = New Store object
                // newStore.Name = name;
                // newStore.City = city;    (newStore.Name newStore.City is calling the setter {set;} method.
                Random rnd = new Random();
                int Id = rnd.Next(1000000);
                Store newStore = new Store {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).

                Id = Id,
                Name = Name,
                Address = Address

                };
                _SFBL.AddStore(newStore);
                break;

                case "2":
                break;

                case "x":
                    exit = true;
                break;



        }
    }

    }
}