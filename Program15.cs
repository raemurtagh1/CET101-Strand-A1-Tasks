using System;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            String sFirstName;
            String sLastName;
            String sProgramme;

            //Enter student first name
            Console.Write("Please enter your first name: ");
            sFirstName = Console.ReadLine();

            //Enter student last name
            Console.Write("Please enter your last name: ");
            sLastName = Console.ReadLine();

            //Enter programme name
            Console.Write("Which programme are you studying? ");
            sProgramme = Console.ReadLine();

            //Saying hello to the student with the programme that they are from
            Console.WriteLine();
            Console.WriteLine("Hello " + sFirstName + " " + sLastName + " from the " + sProgramme + " programme!");

            //Verifying programme closure
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
