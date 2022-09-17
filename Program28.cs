using System;

// add additional classes required for stopwatch and file handling
using System.Diagnostics;
using System.IO;

namespace CalculationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare constants
            const int iNumberOfQuestions = 5;
            const int iRandomNumberMax = 10;
            const int iMillisecondsToSeconds = 1000;
            const String sFILENAME = "scoreboard.txt";

            // declare variables
            int iOption;
            int iCount;
            int iNum1;
            int iNum2;
            int iAnswer;
            int iGuess;
            int iCorrectCount;
            int iTime;

            String sName;

            // create random number generator
            Random random = new Random();

            // create stopwatch
            Stopwatch stopWatch = new Stopwatch();

            // display menu
            MainMenu();

            Console.WriteLine();
            Console.Write("Enter option (1-4): ");
            iOption = Convert.ToInt32(Console.ReadLine());

            // validate user input
            while (iOption < 1 || iOption > 4)
            {
                Console.Write("Invalid option. Please re-enter an option between 1-4: ");
                iOption = Convert.ToInt32(Console.ReadLine());
            }

            // keep looping through program/menu until user selects option 4
            while (iOption != 4)
            {
                Console.Clear();

                // process menu choice
                switch (iOption)
                {
                    case 1: //instructions
                        Console.WriteLine("********* Instructions *********");
                        Console.WriteLine();
                        Console.WriteLine("You will be asked " + iNumberOfQuestions + " questions and your response will be timed.");
                        Console.WriteLine("If you get all of them correct then you will be added to our scoreboard.");
                        break;

                    case 2: // perform test
                        // start stopwatch
                        stopWatch.Start();

                        // initialise count of correct questions answered
                        iCorrectCount = 0;

                        // repeat for each question
                        for (iCount = 1; iCount <= iNumberOfQuestions; iCount++)
                        {
                            // obtain random numbers
                            iNum1 = random.Next(1, iRandomNumberMax);
                            iNum2 = random.Next(1, iRandomNumberMax);

                            // output question
                            Console.Write("Question " + iCount + ": ");
                            Console.Write(iNum1 + " + " + iNum2 + " = ");

                            // read user's answer
                            iGuess = Convert.ToInt32(Console.ReadLine());

                            // calculate correct answer
                            iAnswer = iNum1 + iNum2;

                            Console.WriteLine();

                            // check whether user's answer is correct
                            if (iGuess == iAnswer)
                            {
                                Console.WriteLine("Correct!");

                                // increment count of correct answers
                                iCorrectCount++;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect. The correct answer is " + iAnswer);
                            }

                            Console.WriteLine();
                        }

                        // stop stopwatch and store its time (converted to seconds)
                        stopWatch.Stop();
                        iTime = (int)stopWatch.ElapsedMilliseconds / iMillisecondsToSeconds;

                        // reset stopwatch ready for next time
                        stopWatch.Reset();

                        // output number of correct answers and time taken
                        Console.WriteLine();
                        Console.WriteLine("You answered " + iCorrectCount + " questions correctly.");
                        Console.WriteLine("Your time was " + iTime + " seconds");

                        // check whether all questions are correct
                        if (iCorrectCount == iNumberOfQuestions)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Congratulations! You will be added to our scoreboard.");

                            // obtain user's name
                            Console.Write("Enter your name: ");
                            sName = Console.ReadLine();

                            // append name and time to scoreboard file
                            using (StreamWriter sw = new StreamWriter(sFILENAME, true))
                            {
                                sw.WriteLine(sName + " - " + iTime + " sec");
                                sw.Close();
                            }
                        }

                        break;

                    case 3: // display scoreboard
                        Console.WriteLine("Current Scoreboard");
                        Console.WriteLine();

                        // read scoreboard file and output records
                        using (StreamReader sr = new StreamReader(sFILENAME))
                        {
                            while (sr.Peek() != -1)
                            {
                                Console.WriteLine(sr.ReadLine());
                            }
                            sr.Close();
                        }
                        break;
                }

                // wait for user to press a key
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();

                // display menu again
                MainMenu();

                Console.WriteLine();
                Console.Write("Enter option (1-4): ");
                iOption = Convert.ToInt32(Console.ReadLine());

                // validate user input
                while (iOption < 1 || iOption > 4)
                {
                    Console.Write("Incorrect option. Please re-enter: ");
                    iOption = Convert.ToInt32(Console.ReadLine());
                }
            }

            static void MainMenu()
            {
                Console.WriteLine("Calculator Test Program");
                Console.WriteLine();
                Console.WriteLine("1: Instructions");
                Console.WriteLine("2: Perform Test");
                Console.WriteLine("3: Display Scoreboard");
                Console.WriteLine("4: Exit");
            }
        }
    }
}