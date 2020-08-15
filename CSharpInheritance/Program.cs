using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CSharpInheritance.LunchBuddies;

namespace CSharpInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddies = new LunchBuddies.LunchBuddies();
            var yourGarage = new YourGarage.YourGarage();

            do
            {
                bool runNow;

                runNow = runConsoleApp("Lunch Buddies");

                if (runNow)
                {
                    lunchBuddies.Run();
                }

                runNow = runConsoleApp("Your Garage");

                if (runNow)
                {
                    yourGarage.Run();
                }

            } while (loopProgram());

            bool runConsoleApp(string app)
            {
                Console.WriteLine($"Would you like to run {app}?");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() != "no" && userInput.ToLower() != "n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool loopProgram()
            {
                Console.WriteLine("Do you want to run again?");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "no" || userInput.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
