using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iGrade = 0;

            //asking the student what their grade percentage is
            Console.Write("Please enter your grade percentage for the module: ");
            iGrade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your grade is:");

            if (iGrade < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (iGrade >= 40 && iGrade <= 49)
            {
                Console.WriteLine("Pass - Third");
            }
            else if (iGrade >= 50 && iGrade <= 59)
            {
                Console.WriteLine("Pass - 2.2");
            }
            else if (iGrade >= 60 && iGrade <= 69)
            {
                Console.WriteLine("Pass - 2.1");
            }
            else if (iGrade > 69 && iGrade <= 100)
            {
                Console.WriteLine("Pass - First");
            }
            else
            {
                Console.WriteLine("Error!!!!!!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}