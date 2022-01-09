using Models;
namespace StoreDL;
using Microsoft.Data.SqlClient;
using System.Data;
 public class StaticStorage
{
    private string _connectionString;
    public StaticStorage()
    {
        _connectionString = File.ReadAllText("connectionString.txt");
    }

/// <summary>
/// Returns all customers from _allCustomers List
/// </summary>
/// <typeparam name="Customer">new customer object to add</typeparam>
/// <returns>all customers in the list</returns>
private static List<Customer> _allCustomers = new List<Customer>(); 
public List<Customer> GetAllCustomers() 
{
    return StaticStorage._allCustomers;
}
/// <summary>
/// Add a new customer to the list
/// </summary>
/// <param name="customerToAdd">new customer object to add</param>
public void AddCustomer(Customer customerToAdd)
{
    //Establishing new connection
    using SqlConnection connection = new SqlConnection(_connectionString);
    connection.Open();
    //Our insert command to add a user
    string sqlCmd = "INSERT INTO Customer (Id, Name, UserName, PassWord, Email) VALUES (@Id, @Name, @UserName, @PassWord, @Email)"; 
    using SqlCommand cmdAddUser= new SqlCommand(sqlCmd, connection);
    //Adding paramaters
    cmdAddUser.Parameters.AddWithValue("@Id", customerToAdd.Id);
    cmdAddUser.Parameters.AddWithValue("@Name", customerToAdd.Name);
    cmdAddUser.Parameters.AddWithValue("@UserName", customerToAdd.UserName);
    cmdAddUser.Parameters.AddWithValue("@PassWord", customerToAdd.PassWord);
    cmdAddUser.Parameters.AddWithValue("@Email", customerToAdd.Email);        
    //Executing command
    cmdAddUser.ExecuteNonQuery();
    connection.Close();
}
/// <summary>
/// Returns all stores from allStores List
/// </summary>
/// <returns>all stores in the list</returns>
private static List<Store> _allStores = new List<Store>();
public static List<Store> GetAllStores() 
{
    return StaticStorage._allStores;
}
/// <summary>
/// Adds a new store to the list
/// </summary>
/// <param name="storeToAdd">new store object to add</param>
public static void AddStore(Store storeToAdd)
{
    StaticStorage._allStores.Add(storeToAdd);
 
  }
}  
    


