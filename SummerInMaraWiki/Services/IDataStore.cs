using System.Collections.Generic;
using System.Threading.Tasks;

namespace SummerInMaraWiki.Services
{
    public interface IDataStore<T>
    {
        Task<int> SaveItemAsync(T item);
        Task<int> DeleteItemAsync(string id);
        Task<T> GetItemByIdAsync(string id);
        Task<T> GetItemByCodeAsync(int id);
        Task<List<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
