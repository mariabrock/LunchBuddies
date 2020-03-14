using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Resturant
    {
        private List<string> _options { get; } = new List<string>() { "Chuy's", "Chick-fil-A", "Hardee's", "Jimmy John's" };
        public string ResturantName { get; set; }

        public Resturant ()
        {
            Random rnd = new Random();
            var index = rnd.Next(_options.Count);
            ResturantName = _options[index];
        }

    }
}
