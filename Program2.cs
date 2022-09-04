using System;

namespace BattleGamePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOpponent;
            int iPoints;

            Title();

            Console.WriteLine("What is the grade of your opponent?");
            Console.WriteLine();

            Console.WriteLine("1. Apprentice");
            Console.WriteLine("2. Soldier");
            Console.WriteLine("3. General");
            Console.WriteLine("4. Magician");
            Console.WriteLine();

            Console.Write("Please enter the number of your selection: ");
            iOpponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (iOpponent > 4)
            {
                Console.Clear();

                Title();

                Console.WriteLine("ERROR!!!!");
                Console.WriteLine("You have entered an invalid number.");
                Console.WriteLine("Please try again.");
                Console.WriteLine("______________________________________________");
                Console.WriteLine();

                Console.WriteLine("What is the grade of your opponent?");
                Console.WriteLine();

                Console.WriteLine("1. Apprentice");
                Console.WriteLine("2. Soldier");
                Console.WriteLine("3. General");
                Console.WriteLine("4. Magician");
                Console.WriteLine();

                Console.Write("Please enter the number of your selection: ");
                iOpponent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();
            Title();

            if (iOpponent == 1)
            {
                iPoints = 10;
                Console.WriteLine("You have played with an apprentice...");
                Console.WriteLine("Therefore, you have gained " + iPoints + " points.");
            }
            else if (iOpponent == 2)
            {
                iPoints = 20;
                Console.WriteLine("You have played with a soldier...");
                Console.WriteLine("Therefore, you have gained " + iPoints + " points.");
            }
            else if (iOpponent == 3)
            {
                iPoints = 30;
                Console.WriteLine("You have played with a general...");
                Console.WriteLine("Therefore, you have gained " + iPoints + " points.");
            }
            else
            {
                iPoints = 40;
                Console.WriteLine("You have played with a magician...");
                Console.WriteLine("Therefore, you have gained " + iPoints + " points.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

            static void Title()
            {
                Console.WriteLine("How many points have you gained in the battle?");
                Console.WriteLine("______________________________________________");
                Console.WriteLine();
            }
        }
    }
}
