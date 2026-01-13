using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynewapi.Services
{
    public class Magic8BallServices
    {
        public string GetMagicAnswer()
    {
        Random randomNameGenerator = new Random();
        int randomNumber = randomNameGenerator.Next(1, 10); 

        switch (randomNumber)
        {
            case 1: return "Yes Definitely";
            case 2: return "No Doubt it";
            case 3: return "Most Likely";
            case 4: return "Answer Unclear";
            case 5: return "Yes";
            case 6: return "Ask Again Later";
            case 7: return "Without A Doubt";
            case 8: return "Better Not Tell you";
            default: return "Thank You For Playing!";
        }
    }
}
}