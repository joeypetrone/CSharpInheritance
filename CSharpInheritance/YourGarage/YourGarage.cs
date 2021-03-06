﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance.YourGarage
{
    class YourGarage
    {
        public void Run()
        {
            Console.WriteLine("In Your Garage app.");

            var vehicle = new Vehicle()
            {
                Color = "green",
                PassengerOccupancy = 4
            };

            Console.WriteLine(vehicle.FuelTank);

            vehicle.Refuel();

            Console.WriteLine(vehicle.FuelTank);

            vehicle.FuelTank -= 10;

            Console.WriteLine(vehicle.FuelTank);

            vehicle.Refuel();

            Console.WriteLine(vehicle.FuelTank);


            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            List<Aircraft> planes = new List<Aircraft> { new Boeing747(), new DA40() };

            foreach (var plane in planes)
            {
                plane.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            List<Car> cars = new List<Car> { new NissanLeaf(), new MercedesBenz() };

            foreach(var car in cars)
            {
                car.Drive();
            }


            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            List<Watercraft> boats = new List<Watercraft> { new SeaDoo(), new MasterCraft() };

            foreach (var boat in boats)
            {
                boat.Drive();
            }
        }
    }
}
