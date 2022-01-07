// See https://aka.ms/new-console-template for more information
using Models;   // This is the UI (User Interface) Console application that will be taking all the user input and outputing data to the console.

List<Customer> allCustomers = new List<Customer>();   //Initializes a new instance of the List<T> class 
List<Store> allStores = new List<Store>();
bool exit = false;  // This is a false boolean value that will exit when false. 
Console.WriteLine("==================================");
Console.WriteLine("| WELCOME TO SHARP-E STOREFRONT! |");
Console.WriteLine("==================================");

while(!exit)  // A (Not Exit = not True) while loop
{    
   
    Console.WriteLine("\n***Please choose an option***");
    Console.WriteLine("1. Need an account? Sign up");          //Creating an account
    Console.WriteLine("2. Already have an account? Log in");
    Console.WriteLine("3. Start browsing Sharp-E selections");
    Console.WriteLine("x. Log out");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("\n==Sign up below==");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();  
            Console.WriteLine("\nEmail: ");
            string email = Console.ReadLine(); 
            Console.WriteLine("\nThanks for signing up!!");

            // Store newStore = new Store();  // New Store object
            // newStore.Name = name;
            // newStore.City = address;          // (newStore.Name, newStore.Address is calling the setter {set;} method.

            Customer newCustomer = new Customer {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
            Name = name,
            Email = email,
            };
 
            allCustomers.Add(newCustomer);  
        break;
        case "2":
            Console.WriteLine("\n==Sign in below==");
            Console.WriteLine("UserName: "); 
            string username = Console.ReadLine();
            Console.WriteLine("\nPassWord: ");
            string password = Console.ReadLine();       
            Console.WriteLine("\nYou are now logged into Sharp-E!!");
            
            Customer newCustomer1 = new Customer {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
            UserName = username,
            PassWord = password,  
             

            };
            allCustomers.Add(newCustomer1);
        break;
        case "3":
             
            Console.WriteLine("===================");
            Console.WriteLine("|| Sharp-E Shoes ||");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("|| Sharp-E Pants ||");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("|| Sharp-E Shirts ||");
            Console.WriteLine("===================");
   
            foreach(Store sto in allStores);    //foreach loop

            Store newStore = new Store {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
        
            };
            allStores.Add(newStore);    
            break;   
        case "x":
            exit = true;  // As long as the loop doesn't end with the user saying No, then it keep repeating.
            Console.WriteLine("***GoodBye!!! Thanks for shopping with us***");
        break;

    }
 } 
