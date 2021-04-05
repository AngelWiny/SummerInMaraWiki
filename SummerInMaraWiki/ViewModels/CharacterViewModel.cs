using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using SummerInMaraWiki.ViewModels;
using Xamarin.Forms;

[assembly: Dependency(typeof(CharacterViewModel))]
namespace SummerInMaraWiki.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public CharacterViewModel()
        {
            FillDatabase();
        }

        private List<Character> _characters;



        public List<Character> Characters
        {
            get { return _characters; }
            set { SetProperty(ref _characters, value); }
        }



        private async void FillDatabase()
        {
            CharacterDS = await CharacterDataStore.Instance;
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 1,
                Name = "Koa",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/2/2b/Avatar_Koa_1.png/revision/latest/scale-to-width-down/400?cb=20200615141137"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 2,
                Name = "Napopo",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/3/3c/Napopo-300x348%281%29.png/revision/latest/scale-to-width-down/400?cb=20200615141312"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 3,
                Name = "Yaya Haku",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/9/9f/Yaya-haku-summer-in-mara%281%29.png/revision/latest/scale-to-width-down/1000?cb=20200615142206"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 4,
                Name = "Akaji",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/e/e3/Akaji.png/revision/latest/scale-to-width-down/400?cb=20200615141514"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 5,
                Name = "Saimi",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/c/c6/Avatar_Saimi.png/revision/latest/scale-to-width-down/400?cb=20200615141530"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 6,
                Name = "Onzo",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/9/9b/Avatar_Onzo.png/revision/latest/scale-to-width-down/400?cb=20200615141547"
            });

            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 7,
                Name = "Mayo",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/b/b2/Avatar_Mayo_1.png/revision/latest/scale-to-width-down/400?cb=20200615141603"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 8,
                Name = "Aquila",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/3/3d/Avatar_Aquila.png/revision/latest/scale-to-width-down/400?cb=20200615141620"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 9,
                Name = "Brram",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/a/ad/Avatar_Brram.png/revision/latest/scale-to-width-down/400?cb=20200615141634"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 10,
                Name = "Duna",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/7/7c/Avatar_Dunna.png/revision/latest/scale-to-width-down/400?cb=20200615141650"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 11,
                Name = "Taka",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/d/d1/Avatar_Taka.png/revision/latest/scale-to-width-down/400?cb=20200615141704"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 12,
                Name = "Edegan",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/4/46/Avatar_Edegan.png/revision/latest/scale-to-width-down/400?cb=20200615141717"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 13,
                Name = "Ecco",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/5/54/Avatar_Ecco_1.png/revision/latest/scale-to-width-down/400?cb=20200615141743"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 14,
                Name = "Ereti",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/3/3f/Avatar_Ereti.png/revision/latest/scale-to-width-down/400?cb=20200615141757"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 15,
                Name = "Fink",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/e/e2/Avatar_Fink.png/revision/latest/scale-to-width-down/400?cb=20200615141812"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 16,
                Name = "Littio",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/0/03/Avatar_Litio.png/revision/latest/scale-to-width-down/400?cb=20200615141834"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 17,
                Name = "Rigatta",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/f/f1/Avatar_Rigatta.png/revision/latest/scale-to-width-down/400?cb=20200615141855"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 18,
                Name = "Taima",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/a/ab/Avatar_Taima.png/revision/latest/scale-to-width-down/400?cb=20200615141909"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 19,
                Name = "CB",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/0/09/Avatar_CB.png/revision/latest/scale-to-width-down/400?cb=20200615141926"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 20,
                Name = "Milly",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/e/ed/Milly_Talk-sharedassets2.assets-211.png/revision/latest/scale-to-width-down/1000?cb=20200615141956"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 21,
                Name = "Pilly",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/f/fd/Pilly_Normal-sharedassets2.assets-429.png/revision/latest/scale-to-width-down/1000?cb=20200615142016"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 22,
                Name = "Tilly",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/8/89/Tilly_Talk-sharedassets2.assets-402.png/revision/latest/scale-to-width-down/1000?cb=20200615142036"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 23,
                Name = "Awan",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/a/a7/Awan_Normal-sharedassets2.assets-443.png/revision/latest/scale-to-width-down/1000?cb=20200615142053"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 24,
                Name = "Blu",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/c/c5/Blu_Normal-sharedassets2.assets-397.png/revision/latest/scale-to-width-down/1000?cb=20200615142132"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 25,
                Name = "Noho",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/1/10/Noho.png/revision/latest/scale-to-width-down/512?cb=20200617173427"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 25,
                Name = "Mun",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/f/f7/Mun.png/revision/latest/scale-to-width-down/512?cb=20200617173414"
            });
            await CharacterDS.SaveItemAsync(new Character()
            {
                Code = 25,
                Name = "Caleb",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/3/32/Caleb.png/revision/latest/scale-to-width-down/512?cb=20200617173401"
            });



            Characters = await CharacterDS.GetItemsAsync();
        }
    }
}
