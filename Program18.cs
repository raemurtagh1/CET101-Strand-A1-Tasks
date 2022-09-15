using System;

namespace TipTheWaiter
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables and constants
            double dTipPercent;
            int iNumberOfPeople;
            double dBill;
            double dBillWithTip;
            double dCalculateTip;
            double dTotalBill;
            double dTotalTip;
            
            //input the amount of the bill
            Console.Write("Please enter the amount of the bill = £");
            dBill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("What percentage tip would you like to leave? e.g. (0.20) for 20% = ");
            dTipPercent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            while (dTipPercent > 1)
            {
                Console.Clear();

                Console.WriteLine("*******************************************************************");
                Console.WriteLine("ERROR!!!");
                Console.WriteLine("You have entered an invalid amount.");
                Console.WriteLine("Please enter the tip percentage as a decimal - e.g. 0.20 for 20%");
                Console.WriteLine();
                Console.WriteLine("*******************************************************************");
                Console.WriteLine();

                Console.WriteLine("Please enter the amount of the bill = " + dBill.ToString("C"));
                Console.WriteLine();
                Console.Write("What percentage tip would you like to leave? e.g. (0.20) for 20% = ");
                dTipPercent = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }

            dCalculateTip = dBill * dTipPercent;
            dBillWithTip = dBill + dCalculateTip;

            Console.Clear();
            Console.WriteLine("Please enter the amount of the bill = " + dBill.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("What percentage tip would you like to leave? e.g. (0.20) for 20% = " + dTipPercent);
            Console.WriteLine();

            Console.Write("How many people is the bill split between?: ");
            iNumberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            dTotalBill = dBillWithTip / iNumberOfPeople;
            dTotalTip = dBillWithTip - dBill;

            //display bill and tip
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************** FINAL BILL ***************");
            Console.WriteLine();
            Console.WriteLine("The total amount for each person to pay is: " + dTotalBill.ToString("C"));
            Console.WriteLine("The total tip amount for the waiter is: " + dTotalTip.ToString("C"));

            //end program
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
