using System;

namespace TripCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            double dPriceOfBoat;
            double dPriceOfTrain;
            double dTotalPriceOfTrip;

            //Title of program
            Console.WriteLine("********* Trip Calculator *********");
            Console.WriteLine();

            //Asking user to enter the price of the boat
            Console.Write("Enter the price of the boat: £");
            dPriceOfBoat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Asking user to enter the price of the train
            Console.Write("Enter the price of the train: £");
            dPriceOfTrain = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //Calculation for the total price of the trip
            dTotalPriceOfTrip = dPriceOfBoat + dPriceOfTrain;

            //Display of the total price of the trip
            Console.WriteLine("The total price of the trip is going to be: " + dTotalPriceOfTrip.ToString("C"));

            //Program closure
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}