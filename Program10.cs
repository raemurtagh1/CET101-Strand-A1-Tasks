using System;

namespace Exercise_4._3___AddFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int iIndex, iVal, iTotal = 0;
            for (iIndex = 1; iIndex <= 5; iIndex++)
            {
                Console.Write("Enter number: ");
                iVal = Convert.ToInt32(Console.ReadLine());
                iTotal = iTotal + iVal;
            }
            Console.WriteLine();
            Console.WriteLine("Total = " + iTotal);

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();  
        }
    }
}
