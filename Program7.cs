using System;

namespace Exercise_3._7___Computing_Assignment_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iAssignment_Mark_1;
            int iAssignment_Mark_2;
            int iAssignment_Mark_3;
            int iTotalMark;

            Title();

            //Asking the student what mark they got for their first assignment
            Console.Write("What mark did you get for your first assignment?: ");
            iAssignment_Mark_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the first assignment mark is over 50, error message and ask again
            while (iAssignment_Mark_1 < 0 || iAssignment_Mark_1 > 50)
            {
                Console.Clear();
                Title();

                Console.WriteLine("Error!!!!");
                Console.WriteLine("The total amount of marks you can get from this assignment is 50.");
                Console.WriteLine("Please enter your mark again.");
                Console.WriteLine();

                Console.Write("What mark did you get for your first assignment?: ");
                iAssignment_Mark_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Asking the student what mark they got for their second assignment
            Console.Write("What mark did you get for your second assignment?: ");
            iAssignment_Mark_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the second assignment mark is over 50, error message and ask again
            while (iAssignment_Mark_2 < 0 || iAssignment_Mark_2 > 50)
            {
                Console.Clear();
                Title();

                Console.WriteLine("Error!!!!");
                Console.WriteLine("The total amount of marks you can get from this assignment is 50.");
                Console.WriteLine("Please enter your mark again.");
                Console.WriteLine();

                Console.Write("What mark did you get for your second assignment?: ");
                iAssignment_Mark_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Asking the student what mark they got for their third assignment
            Console.Write("What mark did you get for your third assignment?: ");
            iAssignment_Mark_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If the third assignment mark is over 50, error message and ask again
            while (iAssignment_Mark_3 < 0 || iAssignment_Mark_3 > 50)
            {
                Console.Clear();
                Title();

                Console.WriteLine("Error!!!!");
                Console.WriteLine("The total amount of marks you can get from this assignment is 50.");
                Console.WriteLine("Please enter your mark again.");
                Console.WriteLine();

                Console.Write("What mark did you get for your third assignment?: ");
                iAssignment_Mark_3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Calculating the total marks
            iTotalMark = iAssignment_Mark_1 + iAssignment_Mark_2 + iAssignment_Mark_3;

            //Result title
            Console.Clear();
            Console.WriteLine("***** Assignment Results *****");
            Console.WriteLine();

            //Result of first assignment
            Console.WriteLine("The mark you got for your first assignment is: " + iAssignment_Mark_1 + " marks.");
            Console.WriteLine();

            //Result of second assignment
            Console.WriteLine("The mark you got for your second assignment is: " + iAssignment_Mark_2 + " marks.");
            Console.WriteLine();

            //Result of third assignment
            Console.WriteLine("The mark you got for your third assignment is: " + iAssignment_Mark_3 + " marks.");
            Console.WriteLine();
            Console.WriteLine();

            //If the assignment mark total is 120 - 150
            if (iTotalMark >= 120 && iTotalMark <= 150)
            {
                Console.WriteLine("You have earned " + iTotalMark + " total marks from your 3 assignments.");
                Console.WriteLine();
                Console.WriteLine("Grade = A");
            }

            //If the assignment mark total is 90 - 119
            if (iTotalMark >= 90 && iTotalMark <= 119)
            {
                Console.WriteLine("You have earned " + iTotalMark + " total marks from your 3 assignments.");
                Console.WriteLine();
                Console.WriteLine("Grade = B");
            }

            //If the assignment mark total is 60 - 89
            if (iTotalMark >= 60 && iTotalMark <= 89)
            {
                Console.WriteLine("You have earned " + iTotalMark + " total marks from your 3 assignments.");
                Console.WriteLine();
                Console.WriteLine("Grade = C");
            }

            //If the assignment mark total is 30 - 59
            if (iTotalMark >= 30 && iTotalMark <= 59)
            {
                Console.WriteLine("You have earned " + iTotalMark + " total marks from your 3 assignments."); 
                Console.WriteLine();
                Console.WriteLine("Grade = D");
            }
            
            //If the assignment mark total is under 30
            if (iTotalMark <30)
            {
                Console.WriteLine("You have earned " + iTotalMark + " total marks from your 3 assignments.");
                Console.WriteLine();
                Console.WriteLine("Grade = E");
            }

            //Program closure
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

            static void Title()
            {
                Console.WriteLine("**** Computing Course - Assignment Marks ****");
                Console.WriteLine();
            }
        }
    }
}
