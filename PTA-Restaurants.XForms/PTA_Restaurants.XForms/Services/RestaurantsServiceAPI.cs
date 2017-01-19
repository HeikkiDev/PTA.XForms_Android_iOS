using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTA_Restaurants.XForms.Models;
using System.Net.Http;
using System.Xml.Serialization;
using System.IO;

namespace PTA_Restaurants.XForms.Services
{
    class RestaurantsServiceAPI
    {
        private string RestaurantsListURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/restaurant/v2/summary/1/{0}/{1}/{2}"; // año/mes/día
        private string ImagesURLBase = "http://nrestaurante-neuronable.rhcloud.com/images/logos/{0}"; // nombre de la imagen: propiedad 'logo'
        private string RestaurantDetailURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/restaurant/v2/menu/{0}/{1}/{2}/{3}"; // id de restaurante/año/mes/día
        private string RestaurantDetailMenuURLBase = "http://nrestaurante-neuronable.rhcloud.com/ws/api/product/v2/category/{0}"; // Id de categoría

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantsCollection> GetRestaurants(DateTime today)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantsListURLBase, today.Year, today.Month, today.Day);
                var xml = await client.GetStringAsync(url);
                xml = xml.Substring(55);

                if (string.IsNullOrWhiteSpace(xml))
                    return null;

                RestaurantsCollection restaurantsList = null;
                XmlSerializer serializer = new XmlSerializer(typeof(RestaurantsCollection));

                try
                {
                    using (TextReader reader = new StringReader(xml))
                    {
                        restaurantsList = (RestaurantsCollection)serializer.Deserialize(reader);
                    }
                }
                catch
                {
                    throw;
                }

                return restaurantsList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurant"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantDetailCollection> GetRestaurantDetail(Restaurant restaurant, DateTime today)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantDetailURLBase, restaurant.IdRestaurant, today.Year, today.Month, today.Day);
                var xml = await client.GetStringAsync(url);
                xml = xml.Substring(55);

                if (string.IsNullOrWhiteSpace(xml))
                    return null;

                RestaurantDetailCollection restaurantDetailList = null;
                XmlSerializer serializer = new XmlSerializer(typeof(RestaurantDetailCollection));

                try
                {
                    using (TextReader reader = new StringReader(xml))
                    {
                        restaurantDetailList = (RestaurantDetailCollection)serializer.Deserialize(reader);
                    }
                }
                catch
                {
                    throw;
                }

                return restaurantDetailList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="restaurantDetail"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public async Task<RestaurantDetailMenuCollection> GetRestaurantDetailMenu(RestaurantDetail restaurantDetail)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format(RestaurantDetailMenuURLBase, restaurantDetail.IdMenuCategory);
                var xml = await client.GetStringAsync(url);
                xml = xml.Substring(55);

                if (string.IsNullOrWhiteSpace(xml))
                    return null;

                RestaurantDetailMenuCollection restaurantDetailList = null;
                XmlSerializer serializer = new XmlSerializer(typeof(RestaurantDetailMenuCollection));

                try
                {
                    using (TextReader reader = new StringReader(xml))
                    {
                        restaurantDetailList = (RestaurantDetailMenuCollection)serializer.Deserialize(reader);
                    }
                }
                catch
                {
                    throw;
                }

                return restaurantDetailList;
            }
        }
    }
}
