// See https://aka.ms/new-console-template for more information
using Models;   // This is the UI (User Interface) Console application that will be taking all the user input and outputing data to the console.

List<Store> allStores = new List<Store>();   //Initializes a new instance of the List<T> class (Store)
// ^ This is a list of Stores
bool exit = false;  // This is a false boolean value that will exit when false. 

while(!exit)  // A (Not Exit) while loop
{

    Console.WriteLine("WELCOME TO MY STOREFRONT!");
    Console.WriteLine("***What store would you like to browse?***");
    

    Console.WriteLine("Name: ");
    string name = Console.ReadLine();  

    Console.WriteLine("City: ");
    string city = Console.ReadLine(); 

    Console.WriteLine("State: ");
    string state = Console.ReadLine();  

    // Store newStore = new Store();  // New Store object
    // newStore.Name = name;
    // newStore.City = city;          // (newStore.Name, newStore.City, NewStore.State calling the setter {set;} method.
    // newStore.State = state;

    Store newStore = new Store {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
        Name = name,
        City = city,
        State = state    
    };

    allStores.Add(newStore);    
    Console.WriteLine("***Resent stores you visited today***");
    foreach(Store sto in allStores)    //foreach loop
    {

    Console.WriteLine($"Name: {sto.Name} \nCity: {sto.City} \nState: {sto.State} \n "); // ($) is string interpretation 
                // ^ This is calling the getter {get;} method.   
    }

    Console.WriteLine("Would you like to browse another store? [y/n]");
    string input = Console.ReadLine();
    if(input == "n")  // "If" statement saying (if user input is equal to "No", then exit the app).
    
    {
    exit = true;  // As long as the loop doesn't end with the user saying No, then it keep repeating.
    Console.WriteLine("***Thanks for shopping with us***");
    }

}
