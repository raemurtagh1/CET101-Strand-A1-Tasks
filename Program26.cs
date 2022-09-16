using System;
using System.IO;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice;   // menu choice
            string sBook;  // name of book
            int iNumBooks; // no. of books to enter
            int iIndex;    // loop counter

            //display menu and get user choice
            MainMenu();

            Console.Write("Enter your choice: ");
            iChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();

            while (iChoice < 1 || iChoice > 3)
            {
                MainMenu();

                Console.Write("You must enter 1, 2 or 3, please re-enter choice: ");
                iChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            while (iChoice != 3)
            {
                // create book file
                if (iChoice == 1)
                {
                    Console.WriteLine("*** Rachael's Library ***");
                    Console.WriteLine();
                    Console.Write("How many books do you want to enter? ");
                    iNumBooks = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    //open data file for writing, in APPEND mode
                    using (StreamWriter sw = new StreamWriter("BooksToRead.txt", true))
                    {
                        // loop for each book
                        for (iIndex = 1; iIndex <= iNumBooks; iIndex++)
                        {
                            Console.Write("Enter the name of the book " + iIndex + ": ");
                            sBook = Console.ReadLine();
                            //write book to data file
                            sw.WriteLine(sBook);
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("*****************************************************");
                        Console.WriteLine();

                        if (iNumBooks == 1)
                        {
                            Console.WriteLine("The book has been added to your library.");
                        }
                        else
                        {
                            Console.WriteLine("The books have been added to your library.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else  //read books from data file
                {
                    Console.WriteLine("*** Books in Library ***");
                    Console.WriteLine();

                    // open data file for reading
                    using (StreamReader sr = new StreamReader("BooksToRead.txt"))
                    {
                        iIndex = 0;                             // start counting
                        while (sr.Peek() != -1)                 // while not at end of file
                        {
                            sBook = sr.ReadLine();              // read book from file
                            iIndex++;                           // increment counter
                            Console.WriteLine(" - " + sBook);   // display book details
                        }

                        if (iIndex == 0)
                        {
                            Console.WriteLine("There are 0 books on file.");
                        }
                        else
                        {
                            // display count of books on file
                            Console.WriteLine();
                            Console.WriteLine("There are " + iIndex + " books on file.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                MainMenu();

                Console.Write("Enter your choice: ");
                iChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();

                while (iChoice < 1 || iChoice > 3)
                {
                    MainMenu();

                    Console.Write("You must enter 1, 2 or 3, please re-enter choice: ");
                    iChoice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }

            static void MainMenu()
            {
                Console.WriteLine("*** Welcome to Rachael's Library! ***");
                Console.WriteLine();
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Exit Program");
                Console.WriteLine();
            }
        }
    }
}
