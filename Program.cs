using System;

namespace ArithmeticEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iNum1 = 24, iNum2 = 3, iNum3 = 7;
            int iResult1, iResult2, iResult3, iResult4, iResult5;
            double dVal1, dVal2;

            Console.WriteLine("iNum1 = 24");
            Console.WriteLine("iNum2 = 3");
            Console.WriteLine("iNum3 = 7");
            Console.WriteLine();

            //Equation 1
            Console.WriteLine("Equation 1 = ");
            Console.WriteLine("iResult1 = iNum1 + iNum2 * 2");
            iResult1 = iNum1 + iNum2 * 2;
            Console.WriteLine("Answer: " + iResult1);
            Console.WriteLine();

            //Equation 2
            Console.WriteLine("Equation 2 = ");
            Console.WriteLine("iResult2 = iNum1 + (iNum2 - iNum3) * iNum2");
            iResult2 = iNum1 + (iNum2 - iNum3) * iNum2;
            Console.WriteLine("Answer: " + iResult2);
            Console.WriteLine();

            //Equation 3
            Console.WriteLine("Equation 3 = ");
            Console.WriteLine("iResult3 = 4 * iNum3 - 5");
            iResult3 = 4 * iNum3 - 5;
            Console.WriteLine("Answer: " + iResult3);
            Console.WriteLine();

            //Equation 4
            Console.WriteLine("Equation 4 = ");
            Console.WriteLine("iResult4 = iNum3 / iNum2");
            iResult4 = iNum3 / iNum2;
            Console.WriteLine("Answer: " + iResult4);
            Console.WriteLine();

            //Equation 5
            Console.WriteLine("Equation 5 = ");
            Console.WriteLine("iResult5 = iNum3 % iNum2");
            iResult5 = iNum3 % iNum2;
            Console.WriteLine("Answer: " + iResult5);
            Console.WriteLine();

            //Equation 6
            Console.WriteLine("Equation 6 = ");
            Console.WriteLine("dVal1 = iNum1 / iNum3");
            dVal1 = iNum1 / iNum3;
            Console.WriteLine("Answer: " + dVal1);
            Console.WriteLine();

            //Equation 7
            Console.WriteLine("Equation 7 = ");
            Console.WriteLine("dVal2 = (double)iNum1 / iNum2");
            dVal2 = (double)iNum1 / iNum2;
            Console.WriteLine("Answer: " + dVal2);
            Console.WriteLine();

            //Program closure
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
