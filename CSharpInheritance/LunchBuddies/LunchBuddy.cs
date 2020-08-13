using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.LunchBuddies
{
    class LunchBuddy
    {
        //properties
        public string FirstName { get; }
        public string LastName { get; }

        //constructor
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //methods
        public string eat()
        {
            var restaurant = new Restaurant();

            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}");

            return restaurant.Name;
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food}");
        }

        public void eat(List<LunchBuddy> companions)
        {
            foreach(var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName}");
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            this.eat();

            this.eat(food);

            this.eat(companions);                
        }
    }
}
