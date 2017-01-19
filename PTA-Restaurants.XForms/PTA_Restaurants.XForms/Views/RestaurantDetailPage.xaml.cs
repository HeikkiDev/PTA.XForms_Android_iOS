using PTA_Restaurants.XForms.Models;
using PTA_Restaurants.XForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PTA_Restaurants.XForms.Views
{
    public partial class RestaurantDetailPage : ContentPage
    {
        public RestaurantDetailPage()
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

            RestaurantDetail restaurantDetail = (RestaurantDetail)e.SelectedItem;
            Restaurant restaurant = ((RestaurantDetailViewModel)ListViewRestaurantDetail.BindingContext).Restaurant;

            switch (restaurantDetail.Name)
            {
                case "Ofertas":
                    var restaurantDetailOffers = new RestaurantDetailOffersPage
                    {
                        Title = "PTA Restaurantes",
                        BindingContext = new RestaurantDetailOffersViewModel(restaurant, restaurantDetail, ((RestaurantDetailViewModel)ListViewRestaurantDetail.BindingContext).RestaurantDetailCollection.OfferList)
                    };
                    await Navigation.PushAsync(restaurantDetailOffers, true);
                    break;

                case "Menú del día":
                    var restaurantDailyMenu = new RestaurantDetailDailyMenuPage
                    {
                        Title = "PTA Restaurantes",
                        BindingContext = new RestaurantDetailDailyMenuViewModel(restaurant, restaurantDetail, ((RestaurantDetailViewModel)ListViewRestaurantDetail.BindingContext).RestaurantDetailCollection.DailyMenuList)
                    };
                    await Navigation.PushAsync(restaurantDailyMenu, true);
                    break;

                default:
                    var restaurantDetailPage = new RestaurantDetailMenuPage
                    {
                        Title = "PTA Restaurantes",
                        BindingContext = new RestaurantDetailMenuViewModel(restaurant, restaurantDetail)
                    };
                    await Navigation.PushAsync(restaurantDetailPage, true);
                    break;
            }

            //Disabling Selection...
            ((ListView)sender).SelectedItem = null;
        }
    }
}
