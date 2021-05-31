using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using SummerInMaraWiki.ViewModels;
using SummerInMaraWiki.Views.Character;
using Xamarin.Forms;

[assembly: Dependency(typeof(CharacterViewModel))]
namespace SummerInMaraWiki.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public CharacterViewModel()
        {
            Init();
        }

        public Command<Character> SelectCharacterCommand => new Command<Character>(ViewCharacterDetail);



        private List<Character> _characters;



        public List<Character> Characters
        {
            get { return _characters; }
            set { SetProperty(ref _characters, value); }
        }


        private async void Init()
        {
            Characters = await CharacterDS.GetItemsAsync();
        }
        private async void ViewCharacterDetail(Character SelectedCharacter)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            await Shell.Current.GoToAsync($"{nameof(CharacterDetailPage)}?{nameof(CharacterDetailViewModel.CharacterId)}={SelectedCharacter.Id}");
            IsBusy = false;
        }

    }
}
