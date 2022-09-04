using System;

namespace FencingCharge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            double dLength;
            double dWidth;
            double dTotalMeters;
            const double dCost = 2.35;
            double dTotalCost;

            //Asking what the length of the field is
            Console.Write("What is the length of the rectangular field in meters? ");
            dLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Asking what the width of the field is
            Console.Write("What is the width of the rectangular field in meters? ");
            dWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Calculating the total meters of the field
            dTotalMeters = dLength + dWidth;
            Console.WriteLine("The total amount of meters for the field is: " + dTotalMeters + "m");
            Console.WriteLine();

            //Calculating the total price of the field
            dTotalCost = dTotalMeters * dCost;

            //Saying how much the total cost will be
            Console.WriteLine("So, the total cost of the new fence is: " + dTotalCost.ToString("C"));
            
            //Program closure
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

        }
    }
}
