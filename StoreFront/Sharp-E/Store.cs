    namespace StoreFront;

    public class Store {    //I want to store the name, city and state of store

    //This is a property and a type member
    //Access modifier controls the visibility of type and type members.
    //There are four access modifiers: Public, Private, Internal, Protected
    //public is the most visible, private is the least visible
    //By default, class member has private access modifier
    //Class, by default, are internal unless you explicitely say otherwise
    public string Name { get; set; }
    
    public string City { get; set; }

    public string State { get; set; }

}
