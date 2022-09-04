using System;

namespace RoadTripFuelCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring constants
            const int iMilesPerGallon = 30;
            const double dCostOfFuelPerGallon = 4.80;
            
            //declaring variables
            double dGallonsofFuel;
            int iMilesTraveling;
            double dCostofTrip;

            //How many miles are going to be travelled on the trip
            Console.Write("How many miles are you going to travel? ");
            iMilesTraveling = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Calculating the gallons of fuel needs for the amount of miles traveling
            dGallonsofFuel = iMilesTraveling / iMilesPerGallon;

            //Calculating the cost of the fuel for the trip
            dCostofTrip = dGallonsofFuel * dCostOfFuelPerGallon;

            //Results
            Console.WriteLine("The number of gallons that are needed for the trip are: " +dGallonsofFuel + " gallons");
            Console.WriteLine("The cost of the fuel for the trip is going to be: " + dCostofTrip.ToString("C"));

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
