using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Maps.ViewModels;

namespace Maps.View.DynamicListView
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new PersonViewModels();
        }

    }
}