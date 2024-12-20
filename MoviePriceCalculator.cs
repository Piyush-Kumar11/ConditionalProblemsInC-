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

            double price;
            if(time>=8 && time <= 12)
            {
                if (age < 12)
                {
                    //Discount given
                    price = 120; 
                }
                else if (age >= 12 && age <= 64)
                {
                    price = 180;
                }
                else
                {
                    price = 260;
                }
            }
            else
            {
                if (age < 12)
                {
                    price = 150;
                }
                else if (age >= 12 && age <= 64)
                {
                    price = 200;
                }
                else
                {
                    price = 300;
                }
            }
            Console.WriteLine($"The Movie Price: {price}");
        }
    }
}
