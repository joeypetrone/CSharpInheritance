using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class MercedesBenz : Car
    {
        //properties
        public string Name { get; } = "Mercedes-Benz";

        //methods
        public void SelfPark()
        {
            Console.WriteLine("The Benz begins to park itself.");
        }
    }
}
