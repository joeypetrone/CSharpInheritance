using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class Car : Vehicle
    {
        //methods
        public void Drive()
        {
            Console.WriteLine($"The car moves foward.");
        }

        public void Brake()
        {
            Console.WriteLine("The car slows down.");
        }
    }
}
