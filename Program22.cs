using System;

namespace WagesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            double dRateOfPay;
            int iHoursPerDay;
            int iDaysAWeek;

            double dTotalCashForDay;
            double dTotalCashForWeek;
            double dTotalCashForMonth;
            double dTotalCashForYear;

            int iTotalHoursPerWeek;
            int iTotalHoursPerMonth;

            //Title
            Console.WriteLine("***************** WAGE CALCULATOR *****************");
            Console.WriteLine();

            //Asking rate of pay
            Console.Write("What is your rate of pay?: £");
            dRateOfPay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Asking hours per shift
            Console.Write("How many hours do you do per day?: ");
            iHoursPerDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //if hours is over 12, enter suitable amount
            while (iHoursPerDay > 12)
            {
                Console.WriteLine();
                Console.WriteLine("Error!! Please enter a suitable amount of hours.");
                Console.WriteLine();

                Console.Write("How many hours do you do per day?: ");
                iHoursPerDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Asking days per week
            Console.Write("How many days do you do a week?: ");
            iDaysAWeek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //If days per week is over 7 then enter again
            while (iDaysAWeek > 7)
            {
                Console.WriteLine();
                Console.WriteLine("Error!! There are only 7 days in a week, please enter again");
                Console.WriteLine();

                Console.Write("How many days do you do a week?: ");
                iDaysAWeek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Calculations
            dTotalCashForDay = dRateOfPay * iHoursPerDay;
            dTotalCashForWeek = dTotalCashForDay * iDaysAWeek;
            dTotalCashForMonth = dTotalCashForWeek * 4;
            dTotalCashForYear = dTotalCashForMonth * 12;

            iTotalHoursPerWeek = iHoursPerDay * iDaysAWeek;
            iTotalHoursPerMonth = (iHoursPerDay * iDaysAWeek) * 4;

            //Final sheet
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("***************** TOTALS *****************");
            Console.WriteLine();

            Console.WriteLine("The number of hours you work a day is: " + iHoursPerDay + " hours.");
            Console.WriteLine("The number of days you work a week is: " + iDaysAWeek + " days.");
            Console.WriteLine("So...");
            Console.WriteLine("The total amount of hours that you work a week is: " + iTotalHoursPerWeek + " hours.");
            Console.WriteLine("The total amount of hours you work a month is: " + iTotalHoursPerMonth + " hours.");
            Console.WriteLine();

            Console.WriteLine("Your rate of pay is: " + dRateOfPay.ToString("C"));
            Console.WriteLine("So...");
            Console.WriteLine("Your total pay for each day is: " + dTotalCashForDay.ToString("C"));
            Console.WriteLine("Your total pay for this week is: " + dTotalCashForWeek.ToString("C"));
            Console.WriteLine("Your total pay for this month is: " + dTotalCashForMonth.ToString("C"));
            Console.WriteLine("Your total pay for this year is: " + dTotalCashForYear.ToString("C"));

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}