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

    string input = Console.ReadLine();
    switch(input)
    {
        case "1":
            //Console.WriteLine("** You selected: Browse Items/Checkout **");
                
            // List<Customer> allCustomers = _SFBL.GetAllCustomers();
            // Customer currentuser =  _SFBL.GetCurrentUser(Id);
            // List<Order>  currOrder = currentuser.lineitem;
            // int storeID =0;
            // if(activeuser.Cart == null || currentCart.Count == 0){ 
            //     Console.WriteLine(" You have no items ");
            //     activeuser.Cart = new List<CustomerOrder>();
            // }
            // else{
            //     storeID = currentCart[0].storeID;
            // }
            // decimal CustomerTotal =0;
            
            // //foreach(CustomerOrder currCart in currentCart ){
            // for(int i = 0; i < currentCart.Count; i++){
            // Console.WriteLine($"[{i}] Name: {currentCart[i].ProductName}  \nQuantity: {currentCart[i].Quantity} \nPrice: {currentCart[i].TotalPrice} $ " ); 
            
            // CustomerTotal += currentCart[i].TotalPrice;
            
            // }

            // Console.WriteLine(CustomerTotal);
            // Console.WriteLine("Checkout? Y/N");
            // string checkoutinput = Console.ReadLine();
            // if(checkoutinput == "y"){
            // Console.WriteLine("You chose checkout");
            
            // Checkout(CustomerId,storeID,CustomerTotal, currentCart);
            //}
            //else{
                //break;
            //}


            
           
        break;
        case "2":
            Console.WriteLine("\n***Store info***");
            foreach(Store custo in ss.GetAllStores())
            {
            Console.WriteLine($"Name: {custo.Name} \nAddress: {custo.Address}\n");
            }
            
        break;
        default:
            Console.WriteLine("Not found");
        break;
        }    
    }
  }  
}   
    
      
