using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(CharacterDataStore))]
namespace SummerInMaraWiki.Services
{
    public class CharacterDataStore : SQLiteManager
    {
        readonly List<Character> characters;


            characters = new List<Character>()
            {
                new Character(1,"Koa","https://static.wikia.nocookie.net/summer-in-mara/images/2/2b/Avatar_Koa_1.png/revision/latest/scale-to-width-down/400?cb=20200615141137"),
                new Character(2,"Napopo",  "https://static.wikia.nocookie.net/summer-in-mara/images/3/3c/Napopo-300x348%281%29.png/revision/latest/scale-to-width-down/400?cb=20200615141312"),
                new Character(3,"Yaya Haku","https://static.wikia.nocookie.net/summer-in-mara/images/9/9f/Yaya-haku-summer-in-mara%281%29.png/revision/latest/scale-to-width-down/1000?cb=20200615142206"),
                new Character(4,"Akaji","https://static.wikia.nocookie.net/summer-in-mara/images/e/e3/Akaji.png/revision/latest/scale-to-width-down/400?cb=20200615141514"),
                new Character(5,"Saimi","https://static.wikia.nocookie.net/summer-in-mara/images/c/c6/Avatar_Saimi.png/revision/latest/scale-to-width-down/400?cb=20200615141530"),
                new Character(6,"Onzo","https://static.wikia.nocookie.net/summer-in-mara/images/9/9b/Avatar_Onzo.png/revision/latest/scale-to-width-down/400?cb=20200615141547"),
                new Character(7,"Mayo","https://static.wikia.nocookie.net/summer-in-mara/images/b/b2/Avatar_Mayo_1.png/revision/latest/scale-to-width-down/400?cb=20200615141603"),
                new Character(8,"Aquila","https://static.wikia.nocookie.net/summer-in-mara/images/3/3d/Avatar_Aquila.png/revision/latest/scale-to-width-down/400?cb=20200615141620"),
                new Character(9,"Brram","https://static.wikia.nocookie.net/summer-in-mara/images/a/ad/Avatar_Brram.png/revision/latest/scale-to-width-down/400?cb=20200615141634"),
                new Character(10,"Duna","https://static.wikia.nocookie.net/summer-in-mara/images/7/7c/Avatar_Dunna.png/revision/latest/scale-to-width-down/400?cb=20200615141650"),
                new Character(11,"Taka","https://static.wikia.nocookie.net/summer-in-mara/images/d/d1/Avatar_Taka.png/revision/latest/scale-to-width-down/400?cb=20200615141704"),
                new Character(12,"Edegan","https://static.wikia.nocookie.net/summer-in-mara/images/4/46/Avatar_Edegan.png/revision/latest/scale-to-width-down/400?cb=20200615141717"),
                new Character(13,"Ecco","https://static.wikia.nocookie.net/summer-in-mara/images/5/54/Avatar_Ecco_1.png/revision/latest/scale-to-width-down/400?cb=20200615141743"),
                new Character(14,"Ereti","https://static.wikia.nocookie.net/summer-in-mara/images/3/3f/Avatar_Ereti.png/revision/latest/scale-to-width-down/400?cb=20200615141757"),
                new Character(15,"Fink","https://static.wikia.nocookie.net/summer-in-mara/images/e/e2/Avatar_Fink.png/revision/latest/scale-to-width-down/400?cb=20200615141812"),
                new Character(16,"Littio","https://static.wikia.nocookie.net/summer-in-mara/images/0/03/Avatar_Litio.png/revision/latest/scale-to-width-down/400?cb=20200615141834"),
                new Character(17,"Rigatta","https://static.wikia.nocookie.net/summer-in-mara/images/f/f1/Avatar_Rigatta.png/revision/latest/scale-to-width-down/400?cb=20200615141855"),
                new Character(18,"Taima","https://static.wikia.nocookie.net/summer-in-mara/images/a/ab/Avatar_Taima.png/revision/latest/scale-to-width-down/400?cb=20200615141909"),
                new Character(19,"CB","https://static.wikia.nocookie.net/summer-in-mara/images/0/09/Avatar_CB.png/revision/latest/scale-to-width-down/400?cb=20200615141926"),
                new Character(20,"Milly","https://static.wikia.nocookie.net/summer-in-mara/images/e/ed/Milly_Talk-sharedassets2.assets-211.png/revision/latest/scale-to-width-down/1000?cb=20200615141956"),
                new Character(21,"Pilly","https://static.wikia.nocookie.net/summer-in-mara/images/f/fd/Pilly_Normal-sharedassets2.assets-429.png/revision/latest/scale-to-width-down/1000?cb=20200615142016"),
                new Character(22,"Tilly","https://static.wikia.nocookie.net/summer-in-mara/images/8/89/Tilly_Talk-sharedassets2.assets-402.png/revision/latest/scale-to-width-down/1000?cb=20200615142036"),
                new Character(23,"Awan","https://static.wikia.nocookie.net/summer-in-mara/images/a/a7/Awan_Normal-sharedassets2.assets-443.png/revision/latest/scale-to-width-down/1000?cb=20200615142053"),
                new Character(24,"Blu","https://static.wikia.nocookie.net/summer-in-mara/images/c/c5/Blu_Normal-sharedassets2.assets-397.png/revision/latest/scale-to-width-down/1000?cb=20200615142132"),
                new Character(25,"Noho","https://static.wikia.nocookie.net/summer-in-mara/images/1/10/Noho.png/revision/latest/scale-to-width-down/512?cb=20200617173427"),
                new Character(26,"Mun","https://static.wikia.nocookie.net/summer-in-mara/images/f/f7/Mun.png/revision/latest/scale-to-width-down/512?cb=20200617173414"),
                new Character(27,"Caleb","https://static.wikia.nocookie.net/summer-in-mara/images/3/32/Caleb.png/revision/latest/scale-to-width-down/512?cb=20200617173401"),
            };
        public async Task<int> DeleteItemAsync(string id)
        {
        public async Task<Character> GetItemByIdAsync(int id)
        {
            return await Task.FromResult(characters.FirstOrDefault(x => x.Id == id));
        }

        public async Task<List<Character>> GetItemsAsync()
        }
            return await Task.FromResult(characters);
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
