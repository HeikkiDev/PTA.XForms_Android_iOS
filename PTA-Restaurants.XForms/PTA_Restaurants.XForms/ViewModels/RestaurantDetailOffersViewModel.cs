using PTA_Restaurants.XForms.Models;
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
    class RestaurantDetailOffersViewModel : INotifyPropertyChanged
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
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

        private List<OfferList> offerList;
        public List<OfferList> OfferList
        {
            get { return offerList; }
            set
            {
                offerList = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantDetailOffersViewModel(Restaurant restaurant, RestaurantDetail restaurantDetail, List<OfferList> offerList)
        {
            IsBusy = true;
            this.restaurant = restaurant;
            this.restaurantDetail = restaurantDetail;
            this.offerList = offerList;
            IsBusy = false;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
