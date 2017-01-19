using PTA_Restaurants.XForms.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PTA_Restaurants.XForms.ViewModels
{
    class RestaurantDetailDailyMenuViewModel : INotifyPropertyChanged
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

        private DailyMenuList dailyMenuList;
        public DailyMenuList DailyMenuList
        {
            get { return dailyMenuList; }
            set
            {
                dailyMenuList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<DailyMenuDetail> menuDetailList;
        public ObservableCollection<DailyMenuDetail> MenuDetailList
        {
            get { return menuDetailList; }
            set
            {
                menuDetailList = value;
                OnPropertyChanged();
            }
        }

        // Constructor
        public RestaurantDetailDailyMenuViewModel(Restaurant restaurant, RestaurantDetail restaurantDetail, DailyMenuList dailyMenuList)
        {
            IsBusy = true;
            this.restaurant = restaurant;
            this.restaurantDetail = restaurantDetail;
            this.dailyMenuList = dailyMenuList;
            this .MenuDetailList = setUpList(dailyMenuList);
            IsBusy = false;
        }

        private ObservableCollection<DailyMenuDetail> setUpList(DailyMenuList list)
        {
            DailyMenuList dailyMenuList = list;
            DailyMenuDetail dailyMenuItem = null;
            ObservableCollection<DailyMenuDetail>  menuDetailList = new ObservableCollection<DailyMenuDetail>();

            // Añadimos los primeros
            if (dailyMenuList.FirstCourses != null && dailyMenuList.FirstCourses.Count > 0)
            {
                dailyMenuItem = new DailyMenuDetail
                {
                    isHeader = true,
                    Name = "Primeros"
                };
                menuDetailList.Add(dailyMenuItem);

                foreach (var item in dailyMenuList.FirstCourses)
                {
                    dailyMenuItem = new DailyMenuDetail
                    {
                        isHeader = false,
                        Name = item.Name,
                        Description = item.Description
                    };
                    menuDetailList.Add(dailyMenuItem);
                }
            }

            // Añadimos los segundos
            if (dailyMenuList.SecondCourses != null && dailyMenuList.SecondCourses.Count > 0)
            {
                dailyMenuItem = new DailyMenuDetail
                {
                    isHeader = true,
                    Name = "Segundos"
                };
                menuDetailList.Add(dailyMenuItem);

                foreach (var item in dailyMenuList.SecondCourses)
                {
                    dailyMenuItem = new DailyMenuDetail
                    {
                        isHeader = false,
                        Name = item.Name,
                        Description = item.Description
                    };
                    menuDetailList.Add(dailyMenuItem);
                }
            }

            // Añadimos las guarniciones
            if (dailyMenuList.Garnishes != null && dailyMenuList.Garnishes.Count > 0)
            {
                dailyMenuItem = new DailyMenuDetail
                {
                    isHeader = true,
                    Name = "Guarniciones"
                };
                menuDetailList.Add(dailyMenuItem);

                foreach (var item in dailyMenuList.Garnishes)
                {
                    dailyMenuItem = new DailyMenuDetail
                    {
                        isHeader = false,
                        Name = item.Name,
                        Description = item.Description
                    };
                    menuDetailList.Add(dailyMenuItem);
                }
            }

            // Añadimos los postres
            if (dailyMenuList.Desserts != null && dailyMenuList.Desserts.Count > 0)
            {
                dailyMenuItem = new DailyMenuDetail
                {
                    isHeader = true,
                    Name = "Postres"
                };
                menuDetailList.Add(dailyMenuItem);

                foreach (var item in dailyMenuList.Desserts)
                {
                    dailyMenuItem = new DailyMenuDetail
                    {
                        isHeader = false,
                        Name = item.Name,
                        Description = item.Description
                    };
                    menuDetailList.Add(dailyMenuItem);
                }
            }

            // Añadimos las bebidas
            if (dailyMenuList.Drinks != null && dailyMenuList.Drinks.Count > 0)
            {
                dailyMenuItem = new DailyMenuDetail
                {
                    isHeader = true,
                    Name = "Bebidas"
                };
                menuDetailList.Add(dailyMenuItem);

                foreach (var item in dailyMenuList.Drinks)
                {
                    dailyMenuItem = new DailyMenuDetail
                    {
                        isHeader = false,
                        Name = item.Name,
                        Description = item.Description
                    };
                    menuDetailList.Add(dailyMenuItem);
                }
            }

            return menuDetailList;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
