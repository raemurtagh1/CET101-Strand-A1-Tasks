using System;

namespace StudentProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            String sName;
            String sProgramme;

            //Enter student name
            Console.Write("Enter your name: ");
            sName = Console.ReadLine();

            //Enter programme name
            Console.Write("Which programme are you studying? ");
            sProgramme = Console.ReadLine();

            //Saying hello to the student with the programme that they are from
            Console.WriteLine();
            Console.WriteLine("Hello " + sName + " from " + sProgramme);

            //Verifying programme closure
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}