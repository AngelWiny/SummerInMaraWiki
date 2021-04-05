using SummerInMaraWiki.ViewModels;
using SummerInMaraWiki.Views;
using SummerInMaraWiki.Views.Character;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SummerInMaraWiki
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CharacterDetailPage), typeof(CharacterDetailPage));
        }

    }
}
