// See https://aka.ms/new-console-template for more information
using StoreFront;

List<Store> allStores = new List<Store>();   //Initializes a new instance of the List<T> class (Store)
bool exit = false;

while(!exit)
{

    Console.WriteLine("Welcome to my StoreFront!");
    Console.WriteLine("***Sign Up***");
    Console.WriteLine("***Login***");

    Console.WriteLine("Name: ");
    string name = Console.ReadLine();  

    Console.WriteLine("City: ");
    string city = Console.ReadLine(); 

    Console.WriteLine("State: ");
    string state = Console.ReadLine();  

    Store newStore = new Store();  //New Store object
    newStore.Name = name;
    newStore.City = city;
    newStore.State = state;

    allStores.Add(newStore);    
    Console.WriteLine("Available stores near you");
    foreach(Store sto in allStores)    //foreach loop
    {

    Console.WriteLine($"Name: {sto.Name} \nCity {sto.City} \nState {sto.State} ");
    }

    Console.WriteLine("Would you like to browse another store? [y/n]");
    string input = Console.ReadLine();
    if(input == "n")
    {
    exit = true;
    }

}
