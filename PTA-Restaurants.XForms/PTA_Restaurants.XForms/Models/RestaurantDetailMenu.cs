using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{
    [XmlRoot(ElementName = "productClassifiedV24Bean")]
    public class RestaurantDetailMenu
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "driedFruits")]
        public string DriedFruits { get; set; }
        [XmlElement(ElementName = "eggs")]
        public string Eggs { get; set; }
        [XmlElement(ElementName = "fish")]
        public string Fish { get; set; }
        [XmlElement(ElementName = "gluten")]
        public string Gluten { get; set; }
        [XmlElement(ElementName = "hasNotAlergens")]
        public string HasNotAlergens { get; set; }
        [XmlElement(ElementName = "idProduct")]
        public string IdProduct { get; set; }
        [XmlElement(ElementName = "idProductType")]
        public string IdProductType { get; set; }
        [XmlElement(ElementName = "lupin")]
        public string Lupin { get; set; }
        [XmlElement(ElementName = "milky")]
        public string Milky { get; set; }
        [XmlElement(ElementName = "molluscs")]
        public string Molluscs { get; set; }
        [XmlElement(ElementName = "mustard")]
        public string Mustard { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "peanuts")]
        public string Peanuts { get; set; }
        [XmlElement(ElementName = "price1")]
        public string Price1 { get; set; }
        [XmlElement(ElementName = "price2")]
        public string Price2 { get; set; }
        [XmlElement(ElementName = "price3")]
        public string Price3 { get; set; }
        [XmlElement(ElementName = "price4")]
        public string Price4 { get; set; }
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }

        public bool IsVisiblePrice1 {get; set;}
        public bool IsVisiblePrice2 { get; set; }
        public bool IsVisiblePrice3 { get; set; }
        public bool IsVisiblePrice4 { get; set; }
    }

    [XmlRoot(ElementName = "collection")]
    public class RestaurantDetailMenuCollection
    {
        [XmlElement(ElementName = "productClassifiedV24Bean")]
        public List<RestaurantDetailMenu> RestaurantDetailMenuList { get; set; }
    }

}
