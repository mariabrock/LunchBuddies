using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class theOGBuddy
    {
        public bool theFirst => true;
        public string likesBest { get; set; }
        public string first { get; set; }
        public string last { get; set; }


        public theOGBuddy(string firstName, string lastName)
        {
            first = firstName;
            last = lastName;
        }

        public void Eat()
        {
            Resturant location = new Resturant();
            Console.WriteLine($"{first} {last} is waiting for you at {location.ResturantName}.");
        }

        public void Eat(string food)
        { 
            Console.WriteLine($"{first} {last} ate {food} at the office.");
        }

        public void Eat(List<theOGBuddy> companions)
        {
            Resturant location = new Resturant();
            Console.WriteLine($"{first} {last} is waiting at {location.ResturantName}.");


            foreach (var companion in companions)
            {
                Console.WriteLine(companion.first);
            }

        }

        public void Eat(string food, List<theOGBuddy> companions)
        {
            Resturant location = new Resturant();
            Console.WriteLine($"{first} is at {location.ResturantName}. They ordered {food}. They are with: ");

            foreach (var companion in companions)
            {
                Console.WriteLine(companion.first);
            }
        }
    }
}
