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
    Console.WriteLine("[1]. Need an account? Sign up");          
    Console.WriteLine("[2]. Account holder? Log in");
    Console.WriteLine("[3]. Manager Access Only");
    Console.WriteLine("[4]. Log out");
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
            Console.WriteLine("Sign in below");                        
            Console.WriteLine("enter username");
            string verifyusername = Console.ReadLine();
            List<Customer> customers = ss.GetAllCustomers();
            bool exists = false;
            string loginpassword = "";
            int CustomerId = 0;
            foreach(Customer customer in customers) 
            {       
                if(verifyusername==customer.Username) 
                {
                    Console.WriteLine("Username found");
                    loginpassword=customer.Password;
                    CustomerId = customer.Id;
                    exists=true;
                }
                
            }
            if(exists) 
            {
                System.Console.WriteLine("enter password");
                string checkpassword = Console.ReadLine();
                
                if(loginpassword == checkpassword){

                Console.WriteLine("signed in ");
                new StoreMenu().StartStoreMenu(CustomerId);
                }
                else{
                    Console.WriteLine("Try again");
                }

            }
            else{
                Console.WriteLine("username not found");
            }
            
        break;
        case "3":
            Console.WriteLine("\n*** Manager List ***");         
            new StoreManager().StartManager();
            break;   
        // case "4":
        //     Product p = new Product();
        //     Product p2 = new Product("ProductName", "Description", 125);
        //     Console.WriteLine("***Products in cart*** " + p.ProductName + " " + p.Description + " " +   p.Price);
        //     break;
        case "4":
            exit = true;  // As long as the loop doesn't end with the user saying No, then it keep repeating.
            Console.WriteLine("***Goodbye!! Come back again***");
        break;               
            }

            
        }
    } 
}




    
