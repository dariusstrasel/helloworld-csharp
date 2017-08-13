using System;
namespace Iteration
{
    public class Iteration
    {
        public static void program()
        {
            //For Loops
            for (var i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
			for (var i = 10; i >= 1; i--)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}

            // Foreach

            var name = "John Smith";

            // normal loop

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // foreach loop

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // array foreach

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // while loop

            while (true)
            {
                Console.Write("Write your name:");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else {
                    Console.WriteLine(String.Format("@Echo: {0}", input));
                }
            }
        }
    }
}
