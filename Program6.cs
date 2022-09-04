using System;

namespace Exercise_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int iFirst;
            int iSecond;

            //Asking the user to enter an integer
            Console.Write(" Please enter an integer between 1 and 10: ");
            iFirst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the first number entered is higher than 10
            while (iFirst > 10)
            {
                Console.WriteLine();
                Console.WriteLine(" Error!! The integer you have entered is over 10.");
                Console.WriteLine();
                Console.Write(" Please enter an integer between 1 and 10: ");
                iFirst = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Asking the user to enter another integer
            Console.Write(" Please enter another integer between 1 and 10: ");
            iSecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the second number entered is higher than 10
            while (iSecond > 10)
            {
                Console.WriteLine();
                Console.WriteLine(" Error!! The integer you have entered is over 10.");
                Console.WriteLine();
                Console.Write(" Please enter another integer between 1 and 10: ");
                iSecond = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }

            //Displaying the integers that the user has entered
            Console.WriteLine();
            Console.WriteLine(" Here are the two integers that you entered:");
            Console.WriteLine();

            //If the second number is larger than the first one, swap them.
            if (iSecond > iFirst)
            {
                Console.WriteLine(" " + iSecond);
                Console.WriteLine(" " + iFirst);
                Console.WriteLine();
                Console.WriteLine(" Due to the second number being larger than the first one, they have been swapped.");
                Console.WriteLine();
            }

            //If the first number is equal to the second number, state that they are equal.
            else if (iFirst == iSecond)
            {
                Console.WriteLine(" " + iFirst);
                Console.WriteLine(" " + iSecond);
                Console.WriteLine();
                Console.WriteLine(" The numbers you have entered are equal.");
            }

            //If the first number is larger than the first one, display them as entered
            else
            {
                Console.WriteLine(" " + iFirst);
                Console.WriteLine(" " + iSecond);
                Console.WriteLine();
            }

            //Program closure
            Console.WriteLine();
            Console.WriteLine(" Press any key to close.");
            Console.ReadKey();

            
        }
    }
}
