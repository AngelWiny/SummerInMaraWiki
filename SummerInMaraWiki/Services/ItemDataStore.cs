using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SummerInMaraWiki.Services
{
    public class ItemDataStore : IDataStore<Item>
    {
        readonly List<Item> items;
        public ItemDataStore()
        {
            items = new List<Item>()
        {
                new Item(1,"Acorn","https://static.wikia.nocookie.net/summer-in-mara/images/c/cd/Acorn.png/revision/latest/scale-to-width-down/174?cb=20200718231334")
                ,new Item(2,"Afternoon Tea","https://static.wikia.nocookie.net/summer-in-mara/images/3/31/Afternoon_Tea.JPG/revision/latest/scale-to-width-down/195?cb=20200717030423")
                ,new Item(3,"Ammonite Shell","https://static.wikia.nocookie.net/summer-in-mara/images/a/a6/Ammonite_Shell.png/revision/latest/scale-to-width-down/180?cb=20200718184526")
                ,new Item(4,"Angel Fish","https://static.wikia.nocookie.net/summer-in-mara/images/c/c6/Angel_Fish.png/revision/latest/scale-to-width-down/172?cb=20200801014409")
                ,new Item(5,"Ankora Salad","https://static.wikia.nocookie.net/summer-in-mara/images/3/38/Ankora_Salad.png/revision/latest/scale-to-width-down/166?cb=20200722224736")
                ,new Item(6,"Apple","https://static.wikia.nocookie.net/summer-in-mara/images/7/7d/Apple.png/revision/latest/scale-to-width-down/181?cb=20200718190301")
                ,new Item(7,"Banana","https://static.wikia.nocookie.net/summer-in-mara/images/0/0a/Banana.JPG/revision/latest/scale-to-width-down/244?cb=20200623215912")
                ,new Item(8,"Barrel with Gunpowder","")
                ,new Item(9,"Basic Backpack","https://static.wikia.nocookie.net/summer-in-mara/images/5/5c/Basic_Backpack.png/revision/latest/scale-to-width-down/186?cb=20200801085241")
                ,new Item(10,"Bass","https://static.wikia.nocookie.net/summer-in-mara/images/b/bd/Bass.png/revision/latest/scale-to-width-down/172?cb=20200719010213")

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
