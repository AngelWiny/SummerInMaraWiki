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
    public class CharacterDataStore : IDataStore<Character>
    {
        readonly List<Character> characters;

        public CharacterDataStore()
        {
            characters = new List<Character>()
            {
                new Character(1,"Koa","https://static.wikia.nocookie.net/summer-in-mara/images/3/34/Avatar_Koa.png"),
                new Character(2,"Napopo",  "https://static.wikia.nocookie.net/summer-in-mara/images/9/95/Avatar_Napopo.png"),
                new Character(3,"Yaya Haku","https://static.wikia.nocookie.net/summer-in-mara/images/8/89/Avatar_Haku.png"),
                new Character(4,"Akaji","https://static.wikia.nocookie.net/summer-in-mara/images/e/e3/Akaji.png"),
                new Character(5,"Saimi","https://static.wikia.nocookie.net/summer-in-mara/images/c/c6/Avatar_Saimi.png"),
                new Character(6,"Onzo","https://static.wikia.nocookie.net/summer-in-mara/images/9/9b/Avatar_Onzo.png"),
                new Character(7,"Mayo","https://static.wikia.nocookie.net/summer-in-mara/images/e/ee/Avatar_Mayo.png"),
                new Character(8,"Aquila","https://static.wikia.nocookie.net/summer-in-mara/images/3/3d/Avatar_Aquila.png"),
                new Character(9,"Brram","https://static.wikia.nocookie.net/summer-in-mara/images/a/ad/Avatar_Brram.png"),
                new Character(10,"Duna","https://static.wikia.nocookie.net/summer-in-mara/images/7/7c/Avatar_Dunna.png"),
                new Character(11,"Taka","https://static.wikia.nocookie.net/summer-in-mara/images/d/d1/Avatar_Taka.png"),
                new Character(12,"Edegan","https://static.wikia.nocookie.net/summer-in-mara/images/4/46/Avatar_Edegan.png"),
                new Character(13,"Ecco","https://static.wikia.nocookie.net/summer-in-mara/images/e/e4/Avatar_Ecco.png"),
                new Character(14,"Ereti","https://static.wikia.nocookie.net/summer-in-mara/images/3/3f/Avatar_Ereti.png"),
                new Character(15,"Fink","https://static.wikia.nocookie.net/summer-in-mara/images/e/e2/Avatar_Fink.png"),
                new Character(16,"Littio","https://static.wikia.nocookie.net/summer-in-mara/images/0/03/Avatar_Litio.png"),
                new Character(17,"Rigatta","https://static.wikia.nocookie.net/summer-in-mara/images/f/f1/Avatar_Rigatta.png"),
                new Character(18,"Taima","https://static.wikia.nocookie.net/summer-in-mara/images/a/ab/Avatar_Taima.png"),
                new Character(19,"CB","https://static.wikia.nocookie.net/summer-in-mara/images/0/09/Avatar_CB.png"),
                new Character(20,"Milly","https://static.wikia.nocookie.net/summer-in-mara/images/6/6f/Avatar_Milly.png"),
                new Character(21,"Pilly","https://static.wikia.nocookie.net/summer-in-mara/images/7/72/Avatar_Pilly.png"),
                new Character(22,"Tilly","https://static.wikia.nocookie.net/summer-in-mara/images/b/b0/Avatar_Tilly.png"),
                new Character(23,"Awan","https://static.wikia.nocookie.net/summer-in-mara/images/a/a5/Avatar_Awan.png"),
                new Character(24,"Blu","https://static.wikia.nocookie.net/summer-in-mara/images/0/01/Avatar_Blu.png"),
                new Character(25,"Caleb","https://static.wikia.nocookie.net/summer-in-mara/images/a/ab/Avatar_Caleb.png"),
                new Character(26,"Mun","https://static.wikia.nocookie.net/summer-in-mara/images/3/37/Avatar_Mun.png"),
                new Character(27,"Noho","https://static.wikia.nocookie.net/summer-in-mara/images/f/f9/Avatar_Noho.png"),
            };
        }

        public async Task<Character> GetItemByIdAsync(int id)
        {
            return await Task.FromResult(characters.FirstOrDefault(x => x.Id == id));
        }

        public async Task<List<Character>> GetItemsAsync()
        {
            return await Task.FromResult(characters);
        }
    }
}
