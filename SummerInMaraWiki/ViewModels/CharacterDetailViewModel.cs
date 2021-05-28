using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SummerInMaraWiki.ViewModels
{
    [QueryProperty(nameof(CharacterCode), nameof(CharacterCode))]
    public class CharacterDetailViewModel : BaseViewModel
    {
        public CharacterDetailViewModel()
        {
            CharacterDS = DependencyService.Get<CharacterDataStore>();
        }

        private CharacterDataStore CharacterDS { get; set; }

        private int _characterCode;
        private Character _character;


        public int CharacterCode
        {
            get { return _characterCode; }
            set
            {
                SetProperty(ref _characterCode, value);
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

            Character = await CharacterDS.GetItemByCodeAsync(CharacterCode);

            IsBusy = false;
        }


    }
}
