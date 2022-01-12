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
    
public void StartStoreMenu() {
    StaticStorage ss = new StaticStorage();
    bool exit = false;  
    
while(!exit) 
{
    Console.WriteLine("      ** Store Menu **");
    Console.WriteLine("Please choose an option below\n");
    Console.WriteLine("[1] Browse Items/Checkout");
    Console.WriteLine("[2] Make a Purchase");
    Console.WriteLine("[3] Order History");
    Console.WriteLine("[x] Back to MainMenu");

    string input = Console.ReadLine();
    switch(input)
    {
        case "1":
            Console.WriteLine("** You selected: Browse Items/Checkout **");
            List<Product> StoreInventory =_SFBL.GetAllProduct();
            for(int i = 0; i < StoreInventory.Count; i++){
            Console.WriteLine($"[{i}] Name: {StoreInventory[i].ProductName} \nDescription: {StoreInventory[i].Description} \nPrice: {StoreInventory[i].Price}\n" ); 
            }
        
           
        break;
        case "2":
            Console.WriteLine("\n***Store info***");
            foreach(Store custo in ss.GetAllStores())
            {
            Console.WriteLine($"Name: {custo.Name} \nAddress: {custo.Address}\n");
            }
            
        break;
        case "x":
            exit = true;
        break;
        }    
    }
  }  
}   
    
      
