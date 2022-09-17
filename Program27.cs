using System;
using System.IO;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare constants
            const String sFILENAME = "account.txt";

            // declare variables
            String sName;
            int iOption;
            double dBalance;
            double dAmount;

            // initialise balance
            dBalance = 0;

            // ask user for name and use this to initialise account file
            Console.Write("Please enter your name: ");
            sName = Console.ReadLine();

            // create new, empty account file and output name details
            using (StreamWriter sw = new StreamWriter(sFILENAME))
            {
                sw.WriteLine("      Bank Account for " + sName);
                sw.WriteLine("________________________________________");
                sw.WriteLine();
            }

            // display menu
            Console.Clear();
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

            // keep looping through program/menu until user selects option 4
            while (iOption != 4)
            {
                Console.Clear();

                // process menu choice
                switch (iOption)
                {
                    case 1: //deposit money
                        Console.Write("Enter amount to be deposited in the account: £");
                        dAmount = Convert.ToDouble(Console.ReadLine());
                        dBalance = dBalance + dAmount;

                        Console.WriteLine();
                        Console.WriteLine(dAmount.ToString("C") + " has been deposited.");

                        // append transaction to statement file
                        using (StreamWriter sw = new StreamWriter(sFILENAME, true))
                        {
                            sw.WriteLine(dAmount.ToString("C") + " has been deposited.");
                            sw.WriteLine("Balance: " + dBalance.ToString("C"));
                            sw.WriteLine();
                        }
                        break;

                    case 2: // withdraw money
                        Console.Write("Enter amount to be withdrawn from the account: £");
                        dAmount = Convert.ToDouble(Console.ReadLine());

                        // check if there is enough to withdraw
                        if (dAmount > dBalance)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Insufficient funds to withdraw: " + dAmount.ToString("C"));
                            Console.WriteLine("Balance in account is: " + dBalance.ToString("C"));
                        }
                        else
                        {
                            dBalance = dBalance - dAmount;

                            Console.WriteLine();
                            Console.WriteLine(dAmount.ToString("C") + " has been withdrawn.");
                            Console.WriteLine("Balance is now: " + dBalance.ToString("C"));

                            // append transaction to statement file
                            using (StreamWriter sw = new StreamWriter(sFILENAME, true))
                            {
                                sw.WriteLine(dAmount.ToString("C") + " has been withdrawn.");
                                sw.WriteLine("Balance: " + dBalance.ToString("C"));
                                sw.WriteLine();
                            }
                        }
                        break;

                    case 3: // display statement
                        // read account file and output records
                        using (StreamReader sr = new StreamReader(sFILENAME))
                        {
                            while (sr.Peek() != -1)
                            {
                                Console.WriteLine(sr.ReadLine());
                            }
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
                Console.WriteLine("Simple Bank Account");
                Console.WriteLine();
                Console.WriteLine("1: Deposit money");
                Console.WriteLine("2: Withdraw money");
                Console.WriteLine("3: Display statement");
                Console.WriteLine("4: Exit");
            }
        }
    }
}
