using System;

namespace Bonus_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iSalesAmount;
            int iBonus;

            Title();

            //input the amount of sales that have been made
            Console.Write("How many sales have you made?: £");
            iSalesAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (iSalesAmount > 9999)
            {
                Console.Clear();
                Title();

                Console.WriteLine("ERROR!!!");
                Console.WriteLine("You have entered an invalid amount.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();

                Console.Write("How many sales have you made?: £");
                iSalesAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();
            Title();

            //If the sales amount is not between £0 and £9999
            if (iSalesAmount < 0)
            {
                iBonus = 0;
                Console.WriteLine("Due to making a sales amount of below £0");
                Console.WriteLine("You are getting the bonus of: " + iBonus.ToString("C"));
                AmountBrackets();
            }

            //If the sales amount is £1000 or less
            else if (iSalesAmount < 1000)
            {
                iBonus = 50;
                Console.WriteLine("Due to making a sales amount of " + iSalesAmount.ToString("C"));
                Console.WriteLine("You are getting the bonus of: " + iBonus.ToString("C"));
                AmountBrackets();
            }

            //If the sales amount is between £1001 and £5000
            else if (iSalesAmount > 1001 && iSalesAmount < 5000)
            {
                iBonus = 200;
                Console.WriteLine("Due to making a sales amount of " + iSalesAmount.ToString("C"));
                Console.WriteLine("You are getting the bonus of: " + iBonus.ToString("C"));
                AmountBrackets();
            }

            //If the sales amount is over £5000
            else if (iSalesAmount > 5001)
            {
                iBonus = 600;
                Console.WriteLine("Due to making a sales amount of " + iSalesAmount.ToString("C"));
                Console.WriteLine("You are getting the bonus of: " + iBonus.ToString("C"));
                AmountBrackets();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

            static void Title()
            {
                Console.WriteLine("***** Bonus Calculator *****");
                Console.WriteLine();
            }

            static void AmountBrackets()
            {
                Console.WriteLine();
                Console.WriteLine("____________________________________________");
                Console.WriteLine();
                Console.WriteLine("This is the bonus amount per condition -");
                Console.WriteLine();

                Console.WriteLine("Below £0 - £0 bonus");
                Console.WriteLine("£1000 or less - £50 bonus");
                Console.WriteLine("Between £1001 and £5000 - £200 bonus");
                Console.WriteLine("Greater than £5000 - £600 bonus");
                Console.WriteLine("____________________________________________");
            }
        }
    }
}