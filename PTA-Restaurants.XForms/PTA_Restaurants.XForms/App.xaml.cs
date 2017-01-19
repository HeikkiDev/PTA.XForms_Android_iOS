using PTA_Restaurants.XForms.ViewModels;
using PTA_Restaurants.XForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PTA_Restaurants.XForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PTA_Restaurants.XForms.MainPage();
            var restaurantsPage = new RestaurantsPage
            {
                Title = "PTA Restaurantes",
                BindingContext = new RestaurantsViewModel()
            };

            MainPage = new NavigationPage(restaurantsPage)
            {
                BarBackgroundColor = Color.FromHex("3498db"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
