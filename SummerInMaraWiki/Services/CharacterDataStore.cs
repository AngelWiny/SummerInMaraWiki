using SQLite;
using SummerInMaraWiki.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SummerInMaraWiki.Services
{
    public class CharacterDataStore : IDataStore<Character>
    {
        static SQLiteAsyncConnection Database;

        public CharacterDataStore()
        {
            Database = new SQLiteAsyncConnection(MetaData.DatabasePath, MetaData.DatabaseFlags);
        }

        public static readonly AsyncLazy<CharacterDataStore> Instance = new AsyncLazy<CharacterDataStore>(async () =>
        {
            var instance = new CharacterDataStore();
            CreateTableResult result = await Database.CreateTableAsync<Character>();
            return instance;
        });

        public async Task<int> SaveItemAsync(Character item)
        {
            if (await GetItemByCodeAsync(item.Code) == null)
            {
                item.Id = Guid.NewGuid().ToString();
                return await Database.InsertAsync(item);
            }
            else
            {
                return await Database.UpdateAsync(item);
            }
        }

        public async Task<int> DeleteItemAsync(string id)
        {
            return await Database.DeleteAsync(await GetItemByIdAsync(id));
        }

        public Task<Character> GetItemByIdAsync(string id)
        {
            return Database.Table<Character>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<Character> GetItemByCodeAsync(int code)
        {
            return Database.Table<Character>().Where(i => i.Code == code).FirstOrDefaultAsync();
        }

        public Task<List<Character>> GetItemsAsync(bool forceRefresh = false)
        {
            return Database.Table<Character>().ToListAsync();
        }
    }
}
