using System;
namespace Conditionals
{
    public class Program // Generic class for demonstration
    {
        static void program(string[] args)
        {
            int hour = 10;
            // If / else
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            // Conditional Operator

            bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else 
            //{
            //    price = 29.95f;
            //}

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
				case Season.Winter:
                    Console.WriteLine("It's getting chilly!");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's Spring.");
                    break;

            }
        }
    }
}