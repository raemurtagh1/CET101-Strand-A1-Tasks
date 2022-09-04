using System;

namespace Exercise_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iIndex, iVal, iTotal = 0;
            for (iIndex = 0; iIndex < 7; iIndex++)
            {
                Console.Write("Enter number: ");
                iVal = Convert.ToInt32(Console.ReadLine());
                iTotal = iTotal + iVal;
            }
            Console.WriteLine();
            Console.WriteLine("Total = " + iTotal); 
            Console.WriteLine("Hello World!");
        }
    }
}
