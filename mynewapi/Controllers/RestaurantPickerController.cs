using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mynewapi.Services;

namespace mynewapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
       
       private readonly RestaurantPickerServices _restaurantPickerServices;
       public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }
        [HttpGet]
        [Route("Pick/{category}")]
        public string PickRestaurant(string category)
        {
            return _restaurantPickerServices.GetRestaurant(category);
        }
    }
}