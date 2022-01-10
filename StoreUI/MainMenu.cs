namespace StoreUI;
using Models;
using StoreBL;
using StoreDL;
public class MainMenu {

    private List<Customer> allCustomers = new List<Customer>();   //Initializes a new instance of the List<T> class 
    private List<Store> allStores = new List<Store>();


    public void Start() {
        StaticStorage ss = new StaticStorage();
        bool exit = false;  // This is a false boolean value that will exit when false. 
        Console.WriteLine("==================================");
        Console.WriteLine("| WELCOME TO SHARP-E STOREFRONT! |");
        Console.WriteLine("==================================");
    
while(!exit)  // A (Not Exit = not True) while loop
{    
   
    Console.WriteLine("\n***Choose an options below***");
    Console.WriteLine("1. Need an account? Sign up");          //Creating an account
    Console.WriteLine("2. View Customer Log");
    Console.WriteLine("3. Browse Store selections");
    Console.WriteLine("4. Customer ordered products");
    Console.WriteLine("x. Log out");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("\n==Sign up below==");  
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("\nPassword: ");
            string password = Console.ReadLine();
            Console.WriteLine("\nEmail: ");
            string email = Console.ReadLine(); 
            Console.WriteLine("\nThanks for signing up!!");

            // Store newStore = new Store();  = New Store object
            // newStore.Name = name;
            // newStore.City = city;    (newStore.Name newStore.City is calling the setter {set;} method.
            Random rnd = new Random();
            int Id = rnd.Next(1000000);
            Customer newCustomer = new Customer {  // Another way to initialize a class like the above ^ example and it's called (Object Initializer).

            Id = Id,
            Username = username,
            Password = password,
            Email = email,

            };
            ss.AddCustomer(newCustomer); 
             
        break;
        case "2":
            Console.WriteLine("\n***Customer Log in info***");
            foreach(Customer custo in ss.GetAllCustomers())
            {
            Console.WriteLine($"UserName: {custo.Username} \nPassWord: {custo.Password} \nEmail: {custo.Email}\n");
            }
            
        break;
        case "3":
             new StoreMenu().Start();
           
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




    
