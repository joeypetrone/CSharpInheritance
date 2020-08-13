using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; }
        public string LastName { get; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
