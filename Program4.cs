using System;

namespace EmailSignature
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            String sStaffFirstName;
            String sStaffLastName;
            String sRoomNumber;

            //Entering the first name
            Console.Write("Please enter your first name: ");
            sStaffFirstName = Console.ReadLine();
            Console.WriteLine();

            //Entering the last name
            Console.Write("Please enter your last name: ");
            sStaffLastName = Console.ReadLine();
            Console.WriteLine();

            //Entering the room number
            Console.Write("Please enter your room number: ");
            sRoomNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        
            //Results
            Console.WriteLine("Email Signature = ");
            Console.WriteLine();

            Console.WriteLine(sStaffFirstName + " " + sStaffLastName);
            Console.WriteLine("Room: " + sRoomNumber);
            Console.WriteLine();

            Console.WriteLine("Department of Computing and Technology");
            Console.WriteLine("David Goldman Informatics Centre");
            Console.WriteLine("St Peter's Way");
            Console.WriteLine("Sunderland");
            Console.WriteLine("SR6 0DD");
            Console.WriteLine();
            Console.WriteLine();

            //End program
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}