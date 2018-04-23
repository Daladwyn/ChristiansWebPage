using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChristiansWebPage.Models
{
    public class GuessingGameModel
    {
        static public int GenerateANumber()
        {
            int number = 0;
            Random generatedNumber = new Random();
            number = Convert.ToInt32(generatedNumber.Next(0, 101));

            return number;
        }
    }
}