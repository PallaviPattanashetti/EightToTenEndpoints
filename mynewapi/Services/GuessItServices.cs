using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mynewapi.Services
{
    public class GuessItServices
    {
        public string CheckGuess(string mode, int userGuess)
        {
            Random random = new Random();
            int secretNumber = 0;
            int maxRange = 0;


            switch (mode.ToLower())
            {
                case "easy":
                    secretNumber = random.Next(1, 11);
                    maxRange = 10;
                    break;
                case "medium":
                    secretNumber = random.Next(1, 51);
                    maxRange = 50;
                    break;
                case "hard":
                    secretNumber = random.Next(1, 101);
                    maxRange = 100;
                    break;
                default:
                    return "Invalid mode selected.";
            }

            if (userGuess > secretNumber)
            {
                return $"{userGuess} is higher than the secret number. (Secret was {secretNumber})";
            }
            else if (userGuess < secretNumber)
            {
                return $"{userGuess} is lower than the secret number. (Secret was {secretNumber})";
            }
            else
            {
                return $"Congratulations! {userGuess} is equal to the secret number!";
            }
        }
    }
}