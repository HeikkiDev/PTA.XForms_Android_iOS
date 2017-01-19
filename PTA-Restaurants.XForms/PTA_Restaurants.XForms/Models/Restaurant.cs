using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{

    [XmlRoot(ElementName = "restaurantSummaryV24")]
    public class Restaurant
    {
        [XmlElement(ElementName = "address")]
        public string Address { get; set; }
        [XmlElement(ElementName = "idRestaurant")]
        public string IdRestaurant { get; set; }
        [XmlElement(ElementName = "logo")]
        public string Logo { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "phone")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "buffet")]
        public string Buffet { get; set; }
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
        [XmlElement(ElementName = "halfPrice")]
        public string HalfPrice { get; set; }
        [XmlElement(ElementName = "idDailyMenu")]
        public string IdDailyMenu { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }

        // Propiedad para leer la URL completa de la imagen de cada Restaurante
        private string logoURL = "http://nrestaurante-neuronable.rhcloud.com/images/logos/";
        public string LogoURL
        {
            get { return logoURL + Logo; }
        }
    }

    [XmlRoot(ElementName = "collection")]
    public class RestaurantsCollection
    {
        [XmlElement(ElementName = "restaurantSummaryV24")]
        public List<Restaurant> RestaurantsList { get; set; }
    }
}
