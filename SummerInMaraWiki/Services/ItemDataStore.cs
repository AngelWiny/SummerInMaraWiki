using SQLite;
using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ItemDataStore))]
namespace SummerInMaraWiki.Services
{
    public class ItemDataStore : SQLiteManager
    {

        public ItemDataStore()
        {

        }

        public async Task<int> SaveItemAsync(Item item)
        {
            if (await GetItemByCodeAsync(item.Code) == null)
            {
                return await Database.InsertAsync(item);
            }
            else
            {
                return await Database.UpdateAsync(item);
            }
        }

        public async Task<int> DeleteItemAsync(int code)
        {
            return await Database.DeleteAsync(await GetItemByCodeAsync(code));
        }

        public async Task<Item> GetItemByCodeAsync(int code)
        {
            return await Database.Table<Item>().Where(i => i.Code == code).FirstOrDefaultAsync();
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await Database.Table<Item>().ToListAsync();
        }


    }
}
