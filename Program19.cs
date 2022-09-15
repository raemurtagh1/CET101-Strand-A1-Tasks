using System;

namespace TriangleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            int iSide1 = 0;
            int iSide2 = 0;
            int iSide3 = 0;

            //Inputting the first side
            Console.Write("Enter the value for the first side of the triangle: ");
            iSide1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Inputting the second side
            Console.Write("Enter the value for the second side of the triangle: ");
            iSide2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Inputting the third side
            Console.Write("Enter the value for the third side of the triangle: ");
            iSide3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //calculation for the equilateral triangle
            if (iSide1 == iSide2 && iSide2 == iSide3 && iSide1 == iSide3)
            {
                Console.WriteLine("The triangle is an equilateral triangle");
            }

            //calculation for the isosceles triangle
            else if (iSide1 == iSide2 && iSide1 + iSide2 != iSide3 || 
                    iSide2 == iSide3 && iSide2 + iSide3 != iSide1 || 
                    iSide1 == iSide3 && iSide1 + iSide3 != iSide2)
            {
                Console.WriteLine("The triangle is an isosceles triangle");
            }

            //calculation for the scalene triangle
            else if (iSide1 != iSide2 && iSide2 != iSide3 && iSide1 != iSide3)
            {
                Console.WriteLine("The triangle is a scalene triangle");
            }

            else
            {
                Console.WriteLine("It is not a triangle");
            }

            //program closure
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
} 
