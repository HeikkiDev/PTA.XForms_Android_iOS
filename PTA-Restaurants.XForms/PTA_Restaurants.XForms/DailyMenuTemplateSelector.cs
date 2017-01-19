using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PTA_Restaurants.XForms
{
    class DailyMenuTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplate HeaderTemplate { get; set; }
        public DataTemplate ItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Models.DailyMenuDetail)item).isHeader ? HeaderTemplate : ItemTemplate;
        }
    }
}
