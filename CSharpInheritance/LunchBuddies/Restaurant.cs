using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.LunchBuddies
{
    class Restaurant
    {
        //properties
        public string Name { get; }

        //fields 
        private List<string> _restaurantNames = new List<string> { "Burger King", "Hattie B's", "Sonic", "McDonalds", "Waffle House", "Jack In The Box"};

        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(_restaurantNames.Count);
            Name = _restaurantNames[index];
        }
    }
}
