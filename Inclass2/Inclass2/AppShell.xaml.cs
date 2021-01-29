using Inclass2.ViewModels;
using Inclass2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Inclass2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
