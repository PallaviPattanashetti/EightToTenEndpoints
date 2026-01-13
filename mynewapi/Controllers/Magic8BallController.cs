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
    public class Magic8BallController : ControllerBase
    {
       
        private readonly Magic8BallServices _magic8BallServices;

        public Magic8BallController(Magic8BallServices magic8BallServices)
        {

            _magic8BallServices = magic8BallServices;
        }
        [HttpGet]
        [Route("Fetch/{Ask}")]
        public string GetResponse([FromQuery] string question)
        {
            return _magic8BallServices.GetMagicAnswer();
        }
    }
}