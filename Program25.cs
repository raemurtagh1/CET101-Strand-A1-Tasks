using System;

namespace switch-practice-task
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice;

            Console.Write("Enter an integer: ");
            iChoice = Convert.ToInt32(Console.ReadLine());

            switch (iChoice)
            {
                case 1:
                case 3:
                case 5:
                {
                    Console.WriteLine("Odd number");
                    break;
                }

                case 2:
                case 4:
                case 6:
                {
                    Console.WriteLine("Even number");
                    break;
                }

                default:
                {
                    Console.WriteLine("Number higher than six");
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
