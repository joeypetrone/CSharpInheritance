using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.LunchBuddies
{
    class LunchBuddies
    {
        public void Run()
        {
            Console.WriteLine("In Lunch Buddies app.");

            var lunchBuddy = new LunchBuddy("Jenny", "Chu");
            var hungyBuddy = new LunchBuddy("John", "Doe");
            var sleepyBuddy = new LunchBuddy("Henry", "Flop");
            var skinnyBuddy = new LunchBuddy("Larry", "Sqomp");

            var lunchCompanions = new List<LunchBuddy> { hungyBuddy, sleepyBuddy, skinnyBuddy};

            lunchBuddy.eat();
            lunchBuddy.eat("sandwhich");
            lunchBuddy.eat(lunchCompanions);
            lunchBuddy.eat("another sandwhich", lunchCompanions);
        }
    }
}
