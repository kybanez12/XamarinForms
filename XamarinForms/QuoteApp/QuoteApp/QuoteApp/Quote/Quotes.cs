using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteApp.Quote
{
    public class Quotes
    {
        public string[] quotes = new string[3];
        public string newQuote { get; set; }
        public string oldQuote { get; set; }

        public Quotes()
        {
            quotes[0] = "you suck";
            quotes[1] = "fake it till you make it";
            quotes[2] = "go fast and commit";
        }

        public void GenerateQuote()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, quotes.Length);
            newQuote = quotes[randomNumber];
        }
    }
}
