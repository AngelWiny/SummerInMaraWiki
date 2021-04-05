using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerInMaraWiki.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SummerInMaraWiki.Views.Character
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterListPage : ContentPage
    {
        public CharacterListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

        }
    }
}