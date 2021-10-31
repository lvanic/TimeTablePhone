using System;
using System.Collections.Generic;
using TimeTable.ViewModels;
using TimeTable.Views;
using Xamarin.Forms;

namespace TimeTable
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
