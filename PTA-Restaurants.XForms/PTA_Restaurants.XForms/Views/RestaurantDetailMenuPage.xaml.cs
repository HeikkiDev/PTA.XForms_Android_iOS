using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PTA_Restaurants.XForms.Views
{
    public partial class RestaurantDetailMenuPage : ContentPage
    {
        public RestaurantDetailMenuPage()
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

            //Disabling Selection...
            ((ListView)sender).SelectedItem = null;
        }
    }
}
