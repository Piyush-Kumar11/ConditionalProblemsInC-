using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    internal class Calculator
    {
        public static void BasicCalculator()
        {
            char c;
            do
            {
                Console.WriteLine("Choose from the options:\n1.Addition\n2.Subtraction\n3.Multiply\n4.Divide\n5.Exit!");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("----Addition----");
                        Console.WriteLine("Enter first Num: ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second Num: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sum is: " + (n1 + n2));
                        break;

                    case 2:
                        Console.WriteLine("----Subtraction----");
                        Console.WriteLine("Enter first Num: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second Num: ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Subtraction is: " + (x + y));
                        break;

                    case 3:
                        Console.WriteLine("----Multiplication----");
                        Console.WriteLine("Enter first Num: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second Num: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Multiplication is: " + (a*b));
                        break;

                    case 4:
                        Console.WriteLine("----Division----");
                        Console.WriteLine("Enter first Num: ");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second Num: ");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Division is: " + (a1/a2));
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                }
                Console.WriteLine("Enter Y/y to restart or other key to exit");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
        }
        
    }
}
