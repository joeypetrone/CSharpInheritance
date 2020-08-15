using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class YourGarage
    {
        public void Run()
        {
            Console.WriteLine("In Your Garage app.");

            var car = new Car()
            {
                Color = "green",
                PassengerOccupancy = 4
            };

            Console.WriteLine(car.FuelTank);

            car.Refuel();

            Console.WriteLine(car.FuelTank);

            car.FuelTank -= 10;

            Console.WriteLine(car.FuelTank);

            car.Refuel();

            Console.WriteLine(car.FuelTank);


            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
        }
    }
}
