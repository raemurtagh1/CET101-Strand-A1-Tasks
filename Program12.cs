using System;

namespace KitKatCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring constants
            const int iKitKatCalories = 250;
            const int iWeeksInYear = 52;

            //declaring variables
            int iKitKatsPerWeek;
            int iKitKatsPerYear;
            int iCaloriesPerYear;

            //How many KitKats are eaten in a week
            Console.Write("How many chunky KitKats do you eat in a week? ");
            iKitKatsPerWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Calculating how many KitKats are eaten a year
            iKitKatsPerYear = iKitKatsPerWeek * iWeeksInYear;

            //Calculating how many calories are eaten a year
            iCaloriesPerYear = iKitKatCalories * iKitKatsPerYear;

            //Results
            Console.WriteLine("Because you eat " + iKitKatsPerWeek + " KitKats a week....");
            Console.WriteLine("You are eating " + iKitKatsPerYear + " KitKats per year!");
            Console.WriteLine("Therefore you are putting " + iCaloriesPerYear + " calories in your body a year just from KitKats!");
            Console.WriteLine();
            Console.WriteLine("Yikes, you should cut down your KitKat intake a bit like...");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
