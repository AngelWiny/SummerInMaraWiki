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
            ItemDS = DependencyService.Get<ItemDataStore>();
            FillDatabase();
        }

        private ItemDataStore ItemDS { get; set; }


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




        private async void ViewItemDetail(Item item)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            //await Shell.Current.GoToAsync($"{nameof(CharacterDetailPage)}?{nameof(CharacterDetailViewModel.CharacterId)}={SelectedCharacter.Id}");

            SelectedItem = null;
            IsBusy = false;
        }


        private async void FillDatabase()
        {
            IsBusy = true;

            await ItemDS.SaveItemAsync(new Item()
            {
                Code = 1,
                Name = "Bellota",
                Picture = "https://static.wikia.nocookie.net/summer-in-mara/images/c/cd/Acorn.png/revision/latest/scale-to-width-down/174?cb=20200718231334"
            });
            await ItemDS.SaveItemAsync(new Item()
            {
                Code = 2,
                Name = "Té de la tarde",
                Picture = "https://b7qcmucjl6odk6dhjw3jdiqaoa-ac4c6men2g7xr2a-wikia-nocookie.translate.goog/summer-in-mara/images/3/31/Afternoon_Tea.JPG/revision/latest?cb=20200717030423",

            });


            Items = await ItemDS.GetItemsAsync();
            IsBusy = false;
        }
    }
}
