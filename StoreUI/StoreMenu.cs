using Models;
using StoreDL;
namespace StoreUI;

public class StoreMenu {
    private StaticStorage _SFBL;
   
    public StoreMenu() 
    {
        _SFBL = new StaticStorage();
    }
private List<Store> allStores = new List<Store>();
    
public void StartStoreMenu(int CustomerId) {
    StaticStorage ss = new StaticStorage();
    bool exit = false;  
    
while(!exit) 
{
    Console.WriteLine("***This is the Store Menu***");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("[1] Add a Store");
    Console.WriteLine("[2] Browse all Stores");
    Console.WriteLine("[3] Manager");

    string input = Console.ReadLine();
    switch(input)
    {
        case "1":
            
           
        break;
        case "2":
            Console.WriteLine("\n***Store info***");
            foreach(Store custo in ss.GetAllStores())
            {
            Console.WriteLine($"Name: {custo.Name} \nAddress: {custo.Address}\n");
            }
            
        break;
        case "3":
            
            
        break;
        default:
            Console.WriteLine("Not found");
        break;
        }    
    }
  }  
}   
    
      
