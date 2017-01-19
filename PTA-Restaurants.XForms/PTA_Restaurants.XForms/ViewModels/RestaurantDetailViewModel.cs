using PTA_Restaurants.XForms.Models;
using PTA_Restaurants.XForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PTA_Restaurants.XForms.ViewModels
{
    class RestaurantDetailViewModel : INotifyPropertyChanged
    {
        private RestaurantsServiceAPI RestaurantsService { get; } = new RestaurantsServiceAPI();

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        private bool isVisible = false;
        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; OnPropertyChanged(); }
        }

        private Restaurant restaurant;
        public Restaurant Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                OnPropertyChanged();
            }
        }

        private RestaurantDetailCollection restaurantDetailCollection;
        public RestaurantDetailCollection RestaurantDetailCollection
        {
            get { return restaurantDetailCollection; }
            set
            {
                restaurantDetailCollection = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantDetailViewModel(Restaurant restaurant)
        {
            Restaurant = restaurant;
            ExecuteGetRestaurantDetailCommand(restaurant);
        }

        private Command getRestaurantDetail;

        public Command GetRestaurantDetailCommand
        {
            get
            {
                return getRestaurantDetail ?? (getRestaurantDetail = new Command<Restaurant>(ExecuteGetRestaurantDetailCommand));
            }
        }

        private async void ExecuteGetRestaurantDetailCommand(Restaurant restaurant)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            GetRestaurantDetailCommand.ChangeCanExecute();
            try
            {
                RestaurantDetailCollection = await RestaurantsService.GetRestaurantDetail(restaurant, DateTime.Now);
                if (RestaurantDetailCollection == null 
                    && RestaurantDetailCollection.RestaurantDetailList == null 
                    && RestaurantDetailCollection.RestaurantDetailList.Count == 0
                    && RestaurantDetailCollection.OfferList == null
                    && RestaurantDetailCollection.OfferList.Count == 0
                    && RestaurantDetailCollection.DailyMenuList == null)
                    IsVisible = true;
                else
                    IsVisible = false;

                if (RestaurantDetailCollection.DailyMenuList != null)
                    RestaurantDetailCollection.RestaurantDetailList.Insert(0, new RestaurantDetail { Name = "Menú del día" });

                if (RestaurantDetailCollection.OfferList != null && RestaurantDetailCollection.OfferList.Count != 0)
                    RestaurantDetailCollection.RestaurantDetailList.Insert(0, new RestaurantDetail { Name = "Ofertas" });
            }
            catch
            {
                IsVisible = true;
                RestaurantDetailCollection = null;
            }
            finally
            {
                IsBusy = false;
                GetRestaurantDetailCommand.ChangeCanExecute();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
