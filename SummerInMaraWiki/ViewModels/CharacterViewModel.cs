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
                Picture =
                    "https://static.wikia.nocookie.net/summer-in-mara/images/2/2b/Avatar_Koa_1.png/revision/latest/scale-to-width-down/400?cb=20200615141137"
            });

            Characters = await CharacterDS.GetItemsAsync();
        }
    }
}
