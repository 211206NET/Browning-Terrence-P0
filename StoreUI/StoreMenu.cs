using Models;
using StoreBL;
namespace StoreUI;

public class StoreMenu
{
    public void Start()
    {

        Console.WriteLine("***This is the Store Menu***");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[1] Add a Store");
        Console.WriteLine("[2] Browse all Stores");

        string input = Console.ReadLine();
        bool exit = false;
        switch(input)
        {
            case "1":
            break;
        }


        Console.WriteLine("===================");
        Console.WriteLine("|| Sharp-E Shoes ||");
        Console.WriteLine("===================");
        Console.WriteLine("===================");
        Console.WriteLine("|| Sharp-E Pants ||");
        Console.WriteLine("===================");
        Console.WriteLine("===================");
        Console.WriteLine("|| Sharp-E Shirts ||");
        Console.WriteLine("===================");
    }
}