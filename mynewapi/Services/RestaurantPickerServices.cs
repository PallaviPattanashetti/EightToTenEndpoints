using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynewapi.Services
{
    public class RestaurantPickerServices
    {
        private readonly Random _random = new Random();

        public string GetRestaurant(string category)
        {
            string[] restaurants;

            switch (category.ToLower())
            {
                case "american":
                case "1":
                    restaurants = new string[] { "Taco Bell", "IHOP", "In-N-Out", "McDonald's", "Subway", "Wendy's", "Chills", "Sizzler", "Panera Bread", "Jack In The Box" };
                    break;
                case "indian":
                case "2":
                    restaurants = new string[] { "Bawarchi", "Saffron", "Dosa Hut", "Biriyani Spot", "Curry House", "Taj Mahal", "Rajwadi Thali", "Anand Bhavan", "Ulvacharu", "Idli Kadai" };
                    break;
                case "italian":
                case "3":
                    restaurants = new string[] { "Olive Garden", "Pizza Hut", "Bla Vista", "Mezzo Resaurants", "VIP Pizza", "Happy Pizza", "Nona's Restaurant", "Retro Pie", "Bistro 135", "Villa Napoli" };
                    break;
                default:
                    return "Invalid category. Please choose American, Indian, or Italian.";
            }

            int index = _random.Next(restaurants.Length);
            return $"Suggested Restaurant: {restaurants[index]}";
        }
    }
}