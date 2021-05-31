using System.Collections.Generic;
using System.Threading.Tasks;

namespace SummerInMaraWiki.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetItemByIdAsync(int id);
        Task<List<T>> GetItemsAsync();
    }
}
