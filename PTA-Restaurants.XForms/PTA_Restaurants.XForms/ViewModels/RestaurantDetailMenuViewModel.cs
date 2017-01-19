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
    class RestaurantDetailMenuViewModel : INotifyPropertyChanged
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

        private bool isVisiblePrice1 = false;
        public bool IsVisiblePrice1
        {
            get { return isVisiblePrice1; }
            set { isVisiblePrice1 = value; OnPropertyChanged(); }
        }

        private bool isVisiblePrice2 = false;
        public bool IsVisiblePrice2
        {
            get { return isVisiblePrice2; }
            set { isVisiblePrice2 = value; OnPropertyChanged(); }
        }

        private bool isVisiblePrice3 = false;
        public bool IsVisiblePrice3
        {
            get { return isVisiblePrice3; }
            set { isVisiblePrice3 = value; OnPropertyChanged(); }
        }

        private bool isVisiblePrice4 = false;
        public bool IsVisiblePrice4
        {
            get { return isVisiblePrice4; }
            set { isVisiblePrice4 = value; OnPropertyChanged(); }
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

        private RestaurantDetail restaurantDetail;
        public RestaurantDetail RestaurantDetail
        {
            get { return restaurantDetail; }
            set
            {
                restaurantDetail = value;
                OnPropertyChanged();
            }
        }

        private RestaurantDetailMenuCollection restaurantDetailMenuCollection;
        public RestaurantDetailMenuCollection RestaurantDetailMenuCollection
        {
            get { return restaurantDetailMenuCollection; }
            set
            {
                restaurantDetailMenuCollection = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantDetailMenuViewModel(Restaurant restaurant, RestaurantDetail restaurantDetail)
        {
            Restaurant = restaurant;
            RestaurantDetail = restaurantDetail;
            ExecuteGetRestaurantDetailMenuCommand(restaurantDetail);
        }

        private void setUpPrices()
        {
            IsBusy = true;

            if (!string.IsNullOrEmpty(RestaurantDetail.Price1))
            {
                IsVisiblePrice1 = true;
                for (int i = 0; i < RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count; i++)
                {
                    RestaurantDetailMenuCollection.RestaurantDetailMenuList[i].IsVisiblePrice1 = true;
                }
            }
            if (!string.IsNullOrEmpty(RestaurantDetail.Price2))
            {
                IsVisiblePrice2 = true;
                for (int i = 0; i < RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count; i++)
                {
                    RestaurantDetailMenuCollection.RestaurantDetailMenuList[i].IsVisiblePrice2 = true;
                }
            }
            if (!string.IsNullOrEmpty(RestaurantDetail.Price3))
            {
                IsVisiblePrice3 = true;
                for (int i = 0; i < RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count; i++)
                {
                    RestaurantDetailMenuCollection.RestaurantDetailMenuList[i].IsVisiblePrice3 = true;
                }
            }
            if (!string.IsNullOrEmpty(RestaurantDetail.Price4))
            {
                IsVisiblePrice4 = true;
                for (int i = 0; i < RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count; i++)
                {
                    RestaurantDetailMenuCollection.RestaurantDetailMenuList[i].IsVisiblePrice4 = true;
                }
            }

            IsBusy = false;
        }

        private Command getRestaurantDetailMenu;

        public Command GetRestaurantDetailMenuCommand
        {
            get
            {
                return getRestaurantDetailMenu ?? (getRestaurantDetailMenu = new Command<RestaurantDetail>(ExecuteGetRestaurantDetailMenuCommand));
            }
        }

        private async void ExecuteGetRestaurantDetailMenuCommand(RestaurantDetail restaurantDetail)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            GetRestaurantDetailMenuCommand.ChangeCanExecute();
            try
            {
                RestaurantDetailMenuCollection = await RestaurantsService.GetRestaurantDetailMenu(restaurantDetail);
                if (RestaurantDetailMenuCollection == null || RestaurantDetailMenuCollection.RestaurantDetailMenuList == null || RestaurantDetailMenuCollection.RestaurantDetailMenuList.Count == 0)
                    IsVisible = true;
                else
                    IsVisible = false;
            }
            catch
            {
                IsVisible = true;
                RestaurantDetailMenuCollection = null;
            }
            finally
            {
                setUpPrices();
                IsBusy = false;
                GetRestaurantDetailMenuCommand.ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
