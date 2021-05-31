using SummerInMaraWiki.Models;
using SummerInMaraWiki.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SummerInMaraWiki.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        public ItemViewModel()
        {
            Init();
        }




        private List<Item> _items;
        private Item _selectedItem;




        public List<Item> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
        public Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                ViewItemDetail(value);
            }
        }


        private async void Init()
        {
            Items = await ItemDS.GetItemsAsync();
        }

        private async void ViewItemDetail(Item item)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            //await Shell.Current.GoToAsync($"{nameof(CharacterDetailPage)}?{nameof(CharacterDetailViewModel.CharacterId)}={SelectedCharacter.Id}");

            SelectedItem = null;
            IsBusy = false;
        }
    }
}
