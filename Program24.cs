using System;

namespace WeddingInvitation
{
    class Program
    {
        static void Main(string[] args)
        {
            String sGuest;
            String sBride;
            String sGroom;

            Console.Write("Please enter the name of the guest: ");
            sGuest = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter the name of the bride: ");
            sBride = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Please enter the name of the groom: ");
            sGroom = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Wedding Invitation = ");
            Console.WriteLine("");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                      " + sGuest);
            Console.WriteLine("             " + "is invited to the wedding of:");
            Console.WriteLine("               " + sBride + " and " + sGroom);
            Console.WriteLine("                on Saturday 17th July at 2pm");
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}