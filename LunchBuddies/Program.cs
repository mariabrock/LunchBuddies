using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new theOGBuddy("Maria", "Brock");
            lunchBuddy.Eat();
            lunchBuddy.Eat("taco");


            var lunchBuddy2 = new theOGBuddy("Jameka", "Echols");
            lunchBuddy2.Eat("chilli");


            var lunchBuddy3 = new theOGBuddy("Martin", "Cross");
            lunchBuddy3.Eat("fried chicken");


            List<theOGBuddy> companions = new List<theOGBuddy>();
            companions.Add(lunchBuddy);
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);

            var lunchBuddy4 = new theOGBuddy("Nathan", "G");
            lunchBuddy4.Eat(companions);
            lunchBuddy4.Eat("donuts", companions);


        }
    }
}
