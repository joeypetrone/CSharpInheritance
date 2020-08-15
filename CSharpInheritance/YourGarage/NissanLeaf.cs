using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class NissanLeaf : Car
    {
        //properties
        public string Name { get; } = "Nissan Leaf";

        //method
        public void PlayRadio()
        {
            Console.WriteLine("Some cool tunes begin to play.");
        }
    }
}
