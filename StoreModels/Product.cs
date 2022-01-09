namespace Models;

public class Product
{   
 
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    
    public Product()
    {
        this.ProductName = "\nName: Sharp-E Shoes";
        this.Description = "\nDescription: Black/White - Size 13(Truefit)\nPrice:";
        this.Price = 125.81m;
    }
    public Product(string ProductName, string Description, decimal Price)
    {

    }
    
}