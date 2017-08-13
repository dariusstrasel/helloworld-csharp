using System;
namespace ControlFlow
{
    public class Section5_Lecture48_ControlFlow
    {
        public static void program()
        {
            // 1- Write a program to count how many numbers between 1 and 100 
            // are divisible by 3 with no remainder. Display the count on the 
            // console.
            int counter = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i%2==0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);


            // 2 - Write a program and continuously ask the user to enter a 
            // number or "ok" to exit. Calculate the sum of all the previously 
            // entered numbers and display it on the console.

            int total = 0;
            while (true)
            {
                Console.Write("Enter a number to add:");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                try
                {
                    total += Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input was not a number.");
                }
                continue;
            }

            Console.WriteLine(String.Format("Your Total: {0}", total));


            // 3 - Write a program and ask the user to enter a number. Compute 
            // the factorial of the number and print it on the console. For 
            // example, if the user enters 5, the program should calculate 
            // 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            var random = new Random();
            int userInput = random.Next(1, 20);
            var result = userInput;

            for (int i = 1; i < userInput; i++)
			{
				result = result * i;
			}

            Console.WriteLine(String.Format("{0}! = {1}", userInput, result));

            // 4 - Write a program that picks a random number between 1 and 10. 
            // Give the user 4 chances to guess the number.If the user guesses 
            // the number, display “You won"; otherwise, display “You lost". 
            // (To make sure the program is behaving correctly, you can display 
            // the secret number on the console first.)
            var theNumber = random.Next(1, 10);
            Console.WriteLine(theNumber);
            Console.Write("Guess the random number:");
            var input2 = Console.ReadLine();
            string message;

            if (Convert.ToInt32(input2) == theNumber)
            {
                message = "You won!";
            }
            else 
            {
                message = "You lost";
            }

            Console.WriteLine(message);


			// 5 - Write a program and ask the user to enter a series of 
			// numbers separated by comma.Find the maximum of the numbers and 
			// display it on the console. For example, if the user enters 
			// “5, 3, 8, 1, 4", the program should display 8.
			Console.Write("Input a list of numbers seperated by ");
			// var input2 = Console.ReadLine();
			// string message;

        }
    }
}
