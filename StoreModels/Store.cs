    namespace Models;
    public class Store {    //I want to store the name, city and state of store

    
    //Access modifier controls the visibility of type and type members.
    //There are four access modifiers: Public, Private, Internal, Protected
    //public is the most visible, private is the least visible
    //By default, class member of paticular class has private access modifier if you don't have one.
    //Class, by default, are internal unless you explicitely say otherwise
    public string Name { get; set; }  //This is a property, a type member with a (public) access modifier, (string) datatype and {get; set;} method.
    public int Address { get; set; }  //This is a property, a type member with a a (public) access modifier, (int) datatype and {get; set;} method. 
    public List<Inventory> Inventories { get; set; }
    public List<Order> Orders { get; set; }

}
