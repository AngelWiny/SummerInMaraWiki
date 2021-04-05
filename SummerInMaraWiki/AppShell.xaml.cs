using SummerInMaraWiki.ViewModels;
using SummerInMaraWiki.Views;
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
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        }

    }
}
