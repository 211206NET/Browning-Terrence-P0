using Models;
using StoreDL;

namespace StoreBL;
public class SFBL
{
    public List<Store> GetAllStores()
    {
         return StaticStorage.GetAllStores();
    }
    public void AddStore(Store storeToAdd)
    {
        StaticStorage.AddStore();
    }
}
   