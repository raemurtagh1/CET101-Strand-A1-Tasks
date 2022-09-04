using System;

namespace Exercise_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iIndex;

            for (iIndex = 3; iIndex <= 6; iIndex++)
            {
                Console.WriteLine(iIndex);
            }

            Console.WriteLine();

            for (iIndex = 4; iIndex < 9; iIndex++)
            {
                Console.WriteLine(iIndex);
            }

            Console.WriteLine();

            for (iIndex = (4+1); iIndex < 13; iIndex++)
            {
                Console.WriteLine(iIndex);
            }
        }
    }
}
