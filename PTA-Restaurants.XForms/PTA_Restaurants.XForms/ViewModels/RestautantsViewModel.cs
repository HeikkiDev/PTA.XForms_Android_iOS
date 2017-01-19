using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PTA_Restaurants.XForms.Models;
using PTA_Restaurants.XForms.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace PTA_Restaurants.XForms.ViewModels
{
    public class RestaurantsViewModel : INotifyPropertyChanged
    {
        private RestaurantsServiceAPI RestaurantsService{ get; } = new RestaurantsServiceAPI();

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        private RestaurantsCollection restaurantsCollection;
        public RestaurantsCollection RestaurantsCollection
        {
            get { return restaurantsCollection; }
            set
            {
                restaurantsCollection = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantsViewModel()
        {
            ExecuteGetRestaurantsCommand();
        }

        /*ICommand getRestaurants;
        public ICommand GetRestaurantsCommand =>
                getRestaurants ??
                (getRestaurants = new Command(async () => await ExecuteGetRestaurantsCommand()));*/

        private Command getRestaurants;

        public Command GetRestaurantsCommand
        {
            get
            {
                return getRestaurants ?? (getRestaurants = new Command(ExecuteGetRestaurantsCommand, () =>
                {
                    return !IsBusy;
                }));
            }
        }

        private async void ExecuteGetRestaurantsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            GetRestaurantsCommand.ChangeCanExecute();
            try
            {
                RestaurantsCollection = await RestaurantsService.GetRestaurants(DateTime.Now);
            }
            catch
            {
                RestaurantsCollection = null;
            }
            finally
            {
                IsBusy = false;
                GetRestaurantsCommand.ChangeCanExecute();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
