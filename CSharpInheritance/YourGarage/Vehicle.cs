using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class Vehicle
    {
        //properties
        public int FuelTank { get; set; } = 100;
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        //methods
        public void Refuel()
        {
            if (FuelTank - 10 < 90)
            {
                FuelTank += 10;
            }
        }
    }
}
