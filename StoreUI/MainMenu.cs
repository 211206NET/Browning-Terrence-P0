namespace StoreUI;
using Models;
using StoreDL;

public class MainMenu {
    private List<Customer> allCustomers = new List<Customer>();    
    
    public void Start() {
        StaticStorage ss = new StaticStorage();
        bool exit = false;  
        Console.WriteLine("==================================");
        Console.WriteLine("| WELCOME TO SHARP-E STOREFRONT! |");
        Console.WriteLine("==================================");
    
while(!exit) 
{    

    Console.WriteLine("\n     *** MainMenu ***");
    Console.WriteLine("Please choose an option below\n");
    Console.WriteLine("[1]. Need an account? → Sign up");          
    Console.WriteLine("[2]. Account holder? → Log in ");
    Console.WriteLine("[3]. *Administrator Access Only*");
    Console.WriteLine("[x]. Log out");
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

            
            Random rnd = new Random();
            int Id = rnd.Next(100000);
            Customer newCustomer = new Customer {  

            Id = Id,
            Username = username,
            Password = password,
            Email = email,

            };
            ss.AddCustomer(newCustomer); 
        break;
        case "2":
            Console.WriteLine("Sign in below");                        
            Console.WriteLine("Username:");
            string Username = Console.ReadLine();
            System.Console.WriteLine("Password:");
            string Password = Console.ReadLine();
            {
             Console.WriteLine("\n** You have successfully signed in **\n");  

            };  
            new StoreMenu().StartStoreMenu();
        break;
        case "3":        
            new StoreManager().StartManager();
            break;   
        // case "4":
        //     Product p = new Product();
        //     Product p2 = new Product("ProductName", "Description", 125);
        //     Console.WriteLine("***Products in cart*** " + p.ProductName + " " + p.Description + " " +   p.Price);
        //     break;
        case "x":
            exit = true;  // As long as the loop doesn't end with the user saying No, then it keep repeating.
            Console.WriteLine("***Goodbye!! Come back again***");
            
        break;               
            }

    
        }
    } 
}




    
