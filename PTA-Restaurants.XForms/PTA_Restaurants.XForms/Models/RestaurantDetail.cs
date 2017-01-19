using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTA_Restaurants.XForms.Models
{
    [XmlRoot(ElementName = "restaurantMenuDataV24Bean")]
    public class RestaurantDetailCollection
    {
        // Lista a la que se hace Binding de las categorías de productos
        [XmlElement(ElementName = "categoryList")]
        public List<RestaurantDetail> RestaurantDetailList { get; set; }
        
        //Lista a la que se hace Binding con el Menú Diario
        [XmlElement(ElementName = "dailyMenuList")]
        public DailyMenuList DailyMenuList { get; set; }

        //Lista a la que se hace Binding con las ofertas
        [XmlElement(ElementName = "offerList")]
        public List<OfferList> OfferList { get; set; }
    }

    [XmlRoot(ElementName = "categoryList")]
    public class RestaurantDetail
    {
        [XmlElement(ElementName = "idMenuCategory")]
        public string IdMenuCategory { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "price1")]
        public string Price1 { get; set; }
        [XmlElement(ElementName = "price2")]
        public string Price2 { get; set; }
        [XmlElement(ElementName = "price3")]
        public string Price3 { get; set; }
        [XmlElement(ElementName = "price4")]
        public string Price4 { get; set; }
    }

    [XmlRoot(ElementName = "desserts")]
    public class Desserts
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
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
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }
    }

    [XmlRoot(ElementName = "drinks")]
    public class Drinks
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
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
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }
        [XmlElement(ElementName = "price2")]
        public string Price2 { get; set; }
    }

    [XmlRoot(ElementName = "firstCourses")]
    public class FirstCourses
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
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
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }
    }

    [XmlRoot(ElementName = "garnishes")]
    public class Garnishes
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
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
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }
    }

    [XmlRoot(ElementName = "secondCourses")]
    public class SecondCourses
    {
        [XmlElement(ElementName = "celery")]
        public string Celery { get; set; }
        [XmlElement(ElementName = "crustaceans")]
        public string Crustaceans { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
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
        [XmlElement(ElementName = "sesame")]
        public string Sesame { get; set; }
        [XmlElement(ElementName = "soy")]
        public string Soy { get; set; }
        [XmlElement(ElementName = "sulfites")]
        public string Sulfites { get; set; }
        [XmlElement(ElementName = "vegetarian")]
        public string Vegetarian { get; set; }
    }

    [XmlRoot(ElementName = "dailyMenuList")]
    public class DailyMenuList
    {
        [XmlElement(ElementName = "buffet")]
        public string Buffet { get; set; }
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "desserts")]
        public List<Desserts> Desserts { get; set; }
        [XmlElement(ElementName = "drinks")]
        public List<Drinks> Drinks { get; set; }
        [XmlElement(ElementName = "firstCourses")]
        public List<FirstCourses> FirstCourses { get; set; }
        [XmlElement(ElementName = "garnishes")]
        public List<Garnishes> Garnishes { get; set; }
        [XmlElement(ElementName = "halfPrice")]
        public string HalfPrice { get; set; }
        [XmlElement(ElementName = "idDailyMenu")]
        public string IdDailyMenu { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "secondCourses")]
        public List<SecondCourses> SecondCourses { get; set; }
    }

    [XmlRoot(ElementName = "offerList")]
    public class OfferList
    {
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }
    
}
