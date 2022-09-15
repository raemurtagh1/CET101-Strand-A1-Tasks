using System;
using System.IO;

namespace WagesCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
          //Declaring variables

            //Variable - Rate of Pay
            double dRateOfPay;

            //Variable - Selection of which method to use
            int iSelection;

            //Variables - Hours each day (option 1)
            int iMondaysHours;
            int iTuesdaysHours;
            int iWednesdaysHours;
            int iThursdaysHours;
            int iFridaysHours;
            int iSaturdaysHours;
            int iSundaysHours;

            //Variables - Hours per day & Days per week (option 2)
            int iHoursPerDay;
            int iDaysAWeek;

            //Variable - Total hours done in that week (option 1)
            double iTotalHoursForWeek;

            //Variables - Total cash earned for each day (option 1)
            double dTotalCashForMonday;
            double dTotalCashForTuesday;
            double dTotalCashForWednesday;
            double dTotalCashForThursday;
            double dTotalCashForFriday;
            double dTotalCashForSaturday;
            double dTotalCashForSunday;

            //Variable - Total Cash Earned for the week (option 1)
            //Variable - Potential Cash that can be earned that month (option 1)
            double dTotalCashForWeek_DifferentDays;
            double dPotentialCashForMonth;

            //Variable - Total hours done per week / month (option 2)
            int iTotalHoursPerWeek;
            int iTotalHoursPerMonth;

            //Variable - Total Cash Earned per day / week / month / year (option 2)
            double dTotalCashForDay;
            double dTotalCashForWeek;
            double dTotalCashForMonth;
            double dTotalCashForYear;



            //Display Main Title
            Console.WriteLine("***************** WAGE CALCULATOR *****************");
            Console.WriteLine();

            //Asking rate of pay
            Console.Write("What is your rate of pay?: £");
            //Converting entry to payment
            dRateOfPay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //Title for options
            Console.WriteLine("Would you like to:");
            Console.WriteLine();
            //Option 1
            Console.WriteLine("1. Enter different hours for each day you have done");
            //Option 2
            Console.WriteLine("2. Have the hours be the same for each day - for a set amount of days in the week");
            Console.WriteLine();
            //Confirmation with user of entry input
            Console.WriteLine("Please enter '1' or '2'.");
            Console.WriteLine();
            //Selection entry
            Console.Write("Selection = ");
            //Converting selection into a number
            iSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            //If the selection entered is above 2
            while (iSelection > 2)
            {
                Console.WriteLine();
                //Display ERROR message and prompt user to select another option
                Console.WriteLine("Error!! Please select option 1 or 2.");
                Console.WriteLine();

                //Display options again
                //Title for options
                Console.WriteLine("Would you like to:");
                Console.WriteLine();
                //Option 1
                Console.WriteLine("1. Enter different hours for each day you have done");
                //Option 2
                Console.WriteLine("2. Have the hours be the same for each day - for a set amount of days in the week");
                Console.WriteLine();
                //Confirmation with user of entry input
                Console.WriteLine("Please enter '1' or '2'.");
                Console.WriteLine();
                //Selection entry
                Console.Write("Selection = ");
                //Converting selection into number
                iSelection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }


            //OPTION 1 SELECTED

            //If  Option 1 is entered / selected
            if (iSelection == 1)
            {
                //Clear the console
                Console.Clear();
                //Display Main Title
                Console.WriteLine("***************** WAGE CALCULATOR *****************");
                Console.WriteLine();


                //Monday's Hours

                //Asking user how many hours they did on Monday
                Console.Write("How many hours did you do on Monday?: ");
                //Converting input into a number
                iMondaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iMondaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("ERROR!! Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Monday again
                    Console.Write("How many hours did you do on Monday?: ");
                    //Converting input into a number
                    iMondaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Tuesday's hours

                //Asking the user how many hours they did on Tuesday
                Console.Write("How many hours did you do on Tuesday?: ");
                //Converting input into a number
                iTuesdaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iTuesdaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Tuesday again
                    Console.Write("How many hours did you do on Tuesday?: ");
                    //Converting input into a number
                    iTuesdaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Wednesday's hours

                //Asking the user how many hours they did on Wednesday
                Console.Write("How many hours did you do on Wednesday?: ");
                //Converting input into a number
                iWednesdaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iWednesdaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Wednesday again
                    Console.Write("How many hours did you do on Wednesday?: ");
                    //Converting input into a number
                    iWednesdaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Thursday's hours

                //Asking the user how many hours they did on Thursday
                Console.Write("How many hours did you do on Thursday?: ");
                //Converting input into a number
                iThursdaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iThursdaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Thursday again
                    Console.Write("How many hours did you do on Thursday?: ");
                    //Converting input into a number
                    iThursdaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Friday's hours

                //Asking the user how many hours they did on Friday
                Console.Write("How many hours did you do on Friday?: ");
                //Converting input into a number
                iFridaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iFridaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Friday again
                    Console.Write("How many hours did you do on Friday?: ");
                    //Converting input into a number
                    iFridaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Saturday's hours

                //Asking the user how many hours they did on Saturday
                Console.Write("How many hours did you do on Saturday?: ");
                //Converting input into a number
                iSaturdaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iSaturdaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Saturday again
                    Console.Write("How many hours did you do on Saturday?: ");
                    //Converting input into a number
                    iSaturdaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Sunday's hours

                //Asking the user how many hours they did on Sunday
                Console.Write("How many hours did you do on Sunday?: ");
                //Converting input into a number
                iSundaysHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of hours inputted is over 12
                while (iSundaysHours > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message to user
                    Console.WriteLine("Please enter a suitable amount of hours!");
                    Console.WriteLine();

                    //Ask the user to input the hours that they did on Sunday again
                    Console.Write("How many hours did you do on Sunday?: ");
                    //Converting input into a number
                    iSundaysHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Calculations for the above entries

                //Total cash earned on Monday
                dTotalCashForMonday = dRateOfPay * iMondaysHours;

                //Total cash earned on Tuesday
                dTotalCashForTuesday = dRateOfPay * iTuesdaysHours;

                //Total cash earned on Wednesday
                dTotalCashForWednesday = dRateOfPay * iWednesdaysHours;

                //Total cash earned on Thursday
                dTotalCashForThursday = dRateOfPay * iThursdaysHours;

                //Total cash earned on Friday
                dTotalCashForFriday = dRateOfPay * iFridaysHours;

                //Total cash earned on Saturday
                dTotalCashForSaturday = dRateOfPay * iSaturdaysHours;

                //Total cash earned on Sunday
                dTotalCashForSunday = dRateOfPay * iSundaysHours;


                //Total hours done in that week
                iTotalHoursForWeek = iMondaysHours + iTuesdaysHours + iWednesdaysHours +
                    iThursdaysHours + iFridaysHours + iSaturdaysHours + iSundaysHours;


                //Total cash earned for the week
                dTotalCashForWeek_DifferentDays = dTotalCashForMonday + dTotalCashForTuesday +
                    dTotalCashForWednesday + dTotalCashForThursday + dTotalCashForFriday +
                    dTotalCashForSaturday + dTotalCashForSunday;

                //Potential cash earned for the month
                dPotentialCashForMonth = dTotalCashForWeek_DifferentDays * 4;


                //Final TOTAL Sheet

                //Clear the console
                Console.Clear();
                Console.WriteLine();

                //Main Title
                Console.WriteLine("***************** TOTALS *****************");
                Console.WriteLine();

                //Display the number of hours that the user has worked that week
                Console.WriteLine("The number of hours you have worked this week is: " + iTotalHoursForWeek + " hours");
                Console.WriteLine();

                //Display the rate of pay
                Console.WriteLine("Your rate of pay is: " + dRateOfPay.ToString("C"));
                Console.WriteLine();

                //Display the total pay earned each day from Monday - Sunday
                Console.WriteLine("Your total pay for Monday is: " + dTotalCashForMonday.ToString("C"));
                Console.WriteLine("Your total pay for Tuesday is: " + dTotalCashForTuesday.ToString("C"));
                Console.WriteLine("Your total pay for Wednesday is: " + dTotalCashForWednesday.ToString("C"));
                Console.WriteLine("Your total pay for Thursday is: " + dTotalCashForThursday.ToString("C"));
                Console.WriteLine("Your total pay for Friday is: " + dTotalCashForFriday.ToString("C"));
                Console.WriteLine("Your total pay for Saturday is: " + dTotalCashForSaturday.ToString("C"));
                Console.WriteLine("Your total pay for Sunday is: " + dTotalCashForSunday.ToString("C"));
                Console.WriteLine();

                //Display the total pay for the week
                Console.WriteLine("Your total pay for this week is: " + dTotalCashForWeek_DifferentDays.ToString("C"));

                //Display the potential earnings for the month
                Console.WriteLine("Your potential earnings for this month is: " + dPotentialCashForMonth.ToString("C"));

                //End console code
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to close.");
                Console.ReadKey();
            }

            // OPTION 2 SELECTED

            //If option 2 is entered / selected
            else if (iSelection == 2)
            {
                //Clear the console
                Console.Clear();

                //Display the main title
                Console.WriteLine("***************** WAGE CALCULATOR *****************");
                Console.WriteLine();

                //Ask the user how many hours they work per day
                Console.Write("How many hours do you work per day?: ");
                //Convert input into a number
                iHoursPerDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If number of hours entered is over 12
                while (iHoursPerDay > 12)
                {
                    Console.WriteLine();
                    //Display ERROR message
                    Console.WriteLine("Error!! Please enter a suitable amount of hours.");
                    Console.WriteLine();

                    //Ask the user how many hours they work per day again
                    Console.Write("How many hours do you work per day?: ");
                    //Convert input into a number
                    iHoursPerDay = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }

                //Ask the user how many days they work a week
                Console.Write("How many days do you work a week?: ");
                //Convert input into a number
                iDaysAWeek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //If the number of days entered is over 7
                while (iDaysAWeek > 7)
                {
                    Console.WriteLine();
                    //Display ERROR message
                    Console.WriteLine("Error!! There are only 7 days in a week, please enter again");
                    Console.WriteLine();

                    //Ask user to how many days they work a week again
                    Console.Write("How many days do you do a week?: ");
                    //Convert input into a number
                    iDaysAWeek = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }


                //Calculations

                //Total hours worked per week
                iTotalHoursPerWeek = iHoursPerDay * iDaysAWeek;

                //Total hours worked per month
                iTotalHoursPerMonth = (iHoursPerDay * iDaysAWeek) * 4;


                //Total cash earned per day
                dTotalCashForDay = dRateOfPay * iHoursPerDay;

                //Total cash earned per week
                dTotalCashForWeek = dTotalCashForDay * iDaysAWeek;

                //Total cash earned per month
                dTotalCashForMonth = dTotalCashForWeek * 4;

                //Total cash earned per year
                dTotalCashForYear = dTotalCashForMonth * 12;


                //Final sheet

                //Clear the console
                Console.Clear();

                //Display title
                Console.WriteLine("***************** TOTALS *****************");
                Console.WriteLine();

                //Display the number of hours worked in a day
                Console.WriteLine("The number of hours you work a day is: " + iHoursPerDay + " hours.");

                //Display the number of days worked in a week
                Console.WriteLine("The number of days you work a week is: " + iDaysAWeek + " days.");
                Console.WriteLine();

                //Display the total hours worked in a week
                Console.WriteLine("The total amount of hours that you work a week is: " + iTotalHoursPerWeek + " hours.");

                //Display the total hours worked in a month
                Console.WriteLine("The total amount of hours you work a month is: " + iTotalHoursPerMonth + " hours.");
                Console.WriteLine();
                Console.WriteLine();

                //Display the rate of pay
                Console.WriteLine("Your rate of pay is: " + dRateOfPay.ToString("C"));
                Console.WriteLine();

                //Display total pay for each day
                Console.WriteLine("Your total pay for each day is: " + dTotalCashForDay.ToString("C"));

                //Display total pay for each week
                Console.WriteLine("Your total pay for this week is: " + dTotalCashForWeek.ToString("C"));

                //Display total pay for each month
                Console.WriteLine("Your total pay for this month is: " + dTotalCashForMonth.ToString("C"));

                //Display total pay for each year
                Console.WriteLine("Your total pay for this year is: " + dTotalCashForYear.ToString("C"));

                //End console code
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to close.");
                Console.ReadKey();
            }
        }
    }
}