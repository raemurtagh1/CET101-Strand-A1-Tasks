using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumber = 5;
            if (iNumber > 5)
            {
                iNumber = iNumber + 5;
            }
            else if (iNumber > 2)
            {
                iNumber = iNumber + 10;
            }
            else
            {
                iNumber = iNumber + 15;
            }

            Console.WriteLine(iNumber);
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
