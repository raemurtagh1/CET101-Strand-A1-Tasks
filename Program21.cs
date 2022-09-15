using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iNumCrisps = 10;
            int iCrispsBought;

            //asking the customer how many crisps they would like to buy
            Console.Write("How many crisps do you wish to purchase? ");
            iCrispsBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the number of crisps bought is higher than the amount in the machine
            while (iCrispsBought > iNumCrisps)
            {
                Console.WriteLine("Error!! There is not that many crisps in the machine.");
                Console.WriteLine();
                Console.Write("Please enter another amount: ");
                iCrispsBought = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            // Taking away the number of crisps bought from the number of crisps in the machine
            iNumCrisps = iNumCrisps - iCrispsBought;

            //Telling the user how many crisps are now left in the machine
            if (iCrispsBought == 9)
            {
                Console.WriteLine();
                Console.WriteLine("There is now 1 crisp packet left in the machine.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There are now " + iNumCrisps + " crisp packets left in the machine.");
            }

            //Program closing
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
