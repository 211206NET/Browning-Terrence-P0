using Models;
using StoreDL;

namespace StoreBL;
public class SFBL
{
    /// <summary>
    /// Gets all stores
    /// </summary>
    /// <returns>list of all stores</returns>
    public List<Store> GetAllStores()
    {
         return StaticStorage.GetAllStores();
    }
    /// <summary>
    /// Adds a new store to the list        
    /// </summary>
    /// <param name="storeToAdd">store object to add</param>
    public void AddStore(Store storeToAdd)
    {
        StaticStorage.AddStore(storeToAdd);
    }
}
   