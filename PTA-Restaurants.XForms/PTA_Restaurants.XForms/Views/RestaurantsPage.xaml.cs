using PTA_Restaurants.XForms.Models;
using PTA_Restaurants.XForms.Services;
using PTA_Restaurants.XForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PTA_Restaurants.XForms.Views
{
    public partial class RestaurantsPage : ContentPage
    {
        public RestaurantsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Item selection managing
        /// </summary>
        /// <param name="sender"> Listview </param>
        /// <param name="e"> ListView Item </param>
        async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            Restaurant restaurant = (Restaurant)e.SelectedItem;

            var restaurantDetailPage = new RestaurantDetailPage
            {
                Title = "PTA Restaurantes",
                BindingContext = new RestaurantDetailViewModel(restaurant) // Contains Restaurant object and Menu Detail List
            };

            await Navigation.PushAsync(restaurantDetailPage, true);

            //Disabling Selection...
            ((ListView)sender).SelectedItem = null;
        }
    }
}
