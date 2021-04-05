using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SummerInMaraWiki.ViewModels
{
    [QueryProperty(nameof(CharacterId), nameof(CharacterId))]
    public class CharacterDetailViewModel : BaseViewModel
    {
        public CharacterDetailViewModel()
        {

        }

        private string _characterId;
        private Character _character;

        public string CharacterId
        {
            get { return _characterId; }
            set
            {
                SetProperty(ref _characterId, value);
                FindCharacter();
            }
        }

        public Character Character
        {
            get { return _character; }
            set { SetProperty(ref _character, value); }
        }



        private async void FindCharacter()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            CharacterDS = await CharacterDataStore.Instance;
            Character = await CharacterDS.GetItemByIdAsync(CharacterId);

            IsBusy = false;
        }


    }
}
