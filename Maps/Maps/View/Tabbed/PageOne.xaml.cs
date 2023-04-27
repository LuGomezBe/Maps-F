using Maps.View.AccessApp;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Maps.View.Tabbed
{
    public partial class PageOne : ContentPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestaurantPage());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FarmaciaPage());
        }

        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PizeriaPage());
        }

        
    }
}