using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mynewapi.Services
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)

        {
            _guessItServices = guessItServices;
        }
        [HttpGet]
        [Route("Easy/{guess}")]
        public string GuessEasy(int guess)
        {
            return _guessItServices.CheckGuess("easy", guess);
        }

        [HttpGet]
        [Route("Medium/{guess}")]
        public string GuessMedium(int guess)
        {
            return _guessItServices.CheckGuess("medium", guess);
        }


        [HttpGet]
        [Route("Hard/{guess}")]
        public string GuessHard(int guess)
        {
            return _guessItServices.CheckGuess("hard", guess);
        }
    }
}