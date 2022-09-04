using System;

namespace ProfitLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            double dSales;
            double dOverheads;
            double dProfit;
            double dBonus;
            String sTaxCode;

            //Entering the amount of sales for the year
            Console.Write("Enter amount of sales for the year: £");
            dSales = Convert.ToDouble(Console.ReadLine());

            //Entering the cost of the overheads for the year
            Console.Write("Enter cost of overheads for the year: £");
            dOverheads = Convert.ToDouble(Console.ReadLine());

            //calculate amount of profit or loss
            dProfit = dSales - dOverheads;

            Console.WriteLine();

            //display amount or profit or loss
            if (dProfit > 0)
            {
                Console.WriteLine("This year you made a profit of: " + dProfit.ToString("C"));
            }
            else if (dProfit < 0)
            {
                Console.WriteLine("This year you made a loss of: " + dProfit.ToString("C"));
            }
            else
            {
                Console.WriteLine("This year you have broken even.");
            }

            Console.WriteLine();


            //work out the bonus due
            if (dProfit <= 0)
            {
                dBonus = 0; sTaxCode = "N";
            }
            else if (dProfit > 1 && dProfit <= 1000)
            {
                dBonus = 50; sTaxCode = "A";
            }
            else if (dProfit > 1000 && dProfit <= 5000)
            {
                dBonus = 200; sTaxCode = "B";
            }
            else
            {
                dBonus = 600; sTaxCode = "C";
            }

            Console.WriteLine("You have earned a bonus of: " + dBonus.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Due to:");

            //work out and display the tax code which applies
            switch (sTaxCode)
            {
                case "N":
                    Console.WriteLine("Tax code: N - nothing to pay");
                break;

                case "A":
                    Console.WriteLine("Tax code A - 10%");
                break;

                case "B":
                    Console.WriteLine("Tax code B - 25%");
                break;

                case "C":
                    Console.WriteLine("Tax code C - 40%");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
