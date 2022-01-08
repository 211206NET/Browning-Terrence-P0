namespace StoreUI;
using Models;
public class MainMenu {

    private List<Customer> allCustomers = new List<Customer>();   //Initializes a new instance of the List<T> class 
    private List<Store> allStores = new List<Store>();


    public void Start() {
        bool exit = false;  // This is a false boolean value that will exit when false. 
        Console.WriteLine("==================================");
        Console.WriteLine("| WELCOME TO SHARP-E STOREFRONT! |");
        Console.WriteLine("==================================");
    
while(!exit)  // A (Not Exit = not True) while loop
{    
   
    Console.WriteLine("\n***Please choose an option***");
    Console.WriteLine("1. Need an account? Sign up");          //Creating an account
    Console.WriteLine("2. View customer log");
    Console.WriteLine("3. Browse Sharp-E selections");
    Console.WriteLine("4. Customer ordered products");
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
            Console.WriteLine("\nUserName: ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nPassWord: ");
            string passWord = Console.ReadLine();
            Console.WriteLine("\nVerifyPassword: ");
            string verifyPassword = Console.ReadLine();  
            Console.WriteLine("\nThanks for signing up!!");

            // Store newStore = new Store();  // New Store object
            // newStore.Name = name;
            // newStore.City = address;          // (newStore.Name, newStore.Address is calling the setter {set;} method.

            Customer newCustomer = new Customer {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
            Name = name,
            Email = email,
            UserName = userName,
            PassWord = passWord,

            };
            this.allCustomers.Add(newCustomer);  
        break;
        case "2":
            Console.WriteLine("\n***Customer Log in info***");
            foreach(Customer custo in this.allCustomers)
            {
            Console.WriteLine($"Name: {custo.Name} \nEmail: {custo.Email} \nUserName: {custo.UserName} \nPassWord: {custo.PassWord}\n");
            }
            
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
   
            foreach(Store sto in this.allStores);    //foreach loop

            Store newStore = new Store {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).
        
            };
            this.allStores.Add(newStore);    
            break;   
        case "4":
            Product p = new Product();
            Product p2 = new Product("ProductName", "Description", 125);
            Console.WriteLine("***Products in cart*** " + p.ProductName + " " + p.Description + " " +   p.Price);
            break;
        case "x":
            exit = true;  // As long as the loop doesn't end with the user saying No, then it keep repeating.
            Console.WriteLine("***Goodbye!!! Thanks for shopping with us***");
        break;               
            }
        }
    } 
}




    
