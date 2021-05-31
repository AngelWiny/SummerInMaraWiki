using SQLite;
using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ItemDataStore))]
namespace SummerInMaraWiki.Services
{
    public class ItemDataStore : IDataStore<Item>
    {
        readonly List<Item> items;
        public ItemDataStore()
        {
            items = new List<Item>()
        {
                new Item(1,"Bellota","https://static.wikia.nocookie.net/summer-in-mara/images/c/cd/Acorn.png/revision/latest/scale-to-width-down/174?cb=20200718231334"),
                new Item(2,"Té de la tarde","https://b7qcmucjl6odk6dhjw3jdiqaoa-ac4c6men2g7xr2a-wikia-nocookie.translate.goog/summer-in-mara/images/3/31/Afternoon_Tea.JPG/revision/latest?cb=20200717030423")
            };
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(x => x.Id == id));
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await Task.FromResult(items);
        }

    }
}
