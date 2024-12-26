using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    internal class MoviePriceCalculator
    {
        public static void CalculateMoviePrice()
        {
            Console.WriteLine("Enter the Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time[1-24]: ");
            int time = Convert.ToInt32(Console.ReadLine());

            double price =0.0;
            if(time>=8 && time <= 12)
            {
                if (age <= 0)
                {
                    try
                    {
                        throw new InvalidAgeException();
                    }
                    catch(InvalidAgeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                if (age < 12 && age>0)
                {
                    //Discount given
                    price = 120; 
                }
                else if (age >= 12 && age <= 64)
                {
                    price = 180;
                }
                
            }
            else
            {
                if (age <= 0)
                {
                    try
                    {
                        throw new InvalidAgeException();
                    }
                    catch (InvalidAgeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if (age < 12 && age>0)
                {
                    price = 150;
                }
                else if (age >= 12 && age <= 64)
                {
                    price = 200;
                }
           
            }
            Console.WriteLine($"The Movie Price: {price}");
        }
    }
}
