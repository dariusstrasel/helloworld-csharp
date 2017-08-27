using System;
using System.Collections.Generic;
namespace helloworldcsharp.Exercises
{
    public class Section6_Lecture55_Lists
    {
        public static void Lists()
        {
            // 1 - When you post a message on Facebook, depending on the number 
            // of people who like your post, Facebook displays different 
            // information.

            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: 
            // [Friend's Name] likes your post.
            // If two people like your post, it displays: [Friend 1]
            // and[Friend 2] like your post.
            // If more than two people like your post, it displays: 
            // [Friend 1], [Friend 2] and[Number of Other People] others 
            // like your post.
            // Write a program and continuously ask the user to enter 
            // different names, until the user presses Enter (without supplying 
            // a name). Depending on the number of names provided, display a 
            // message based on the above pattern.
            var names = new List<string>();
			Console.WriteLine("Enter names of people who liked your post:");
            while (true)
			{
				Console.Write("Name:");
				var input = Console.ReadLine();
				if (input == "ok")
				{
					break;
				}
				try
				{
					names.Add(input);
				}
				catch (FormatException e)
				{
					Console.WriteLine("Input was not a number.");
				}
				continue;
			}
            string message = "";
            if (names.Count > 2)
            {
                message = String.Format("{0}, {1}, and {2} others liked your post.", names[0], names[1], names.Count - 2);
            }
            if (names.Count == 2)
            {
                message = String.Format("{0} and {1} liked your post.", names[0], names[1]);
            }
            if (names.Count == 1)
            {
                message = String.Format("{0} liked your post.", names[0]);
            }
            Console.WriteLine(message);


			// 2- Write a program and ask the user to enter their name.Use an 
			// array to reverse the name and then store the result in a new 
			// string. Display the reversed name on the console.

			Console.Write("Enter your name:");
			var input2 = Console.ReadLine();
            var arrayString = new string[input2.Length];
            for (var i = 0; i < input2.Length; i++)
            {
                arrayString[i] = input2[i].ToString();
            }

            Array.Reverse(arrayString);
            foreach (var charac in arrayString)
            {
                Console.WriteLine(charac);
            }
			// 3- Write a program and ask the user to enter 5 numbers.If a 
			// number has been previously entered, display an error message
			// and ask the user to re-try. Once the user successfully enters
			// 5 unique numbers, sort them and display the result on the console
			var numbers = new List<int>();
            Console.WriteLine("Enter five unique numbers.");

            while (numbers.Count != 5)
			{
				Console.Write("Number:");
                var input3 = Console.ReadLine();
				try
                {
                    if (numbers.Contains(Convert.ToInt32(input3)))
                    {
						Console.WriteLine("This number has already been entered.");
                    }
                    else
                    {
                        numbers.Add(Convert.ToInt32(input3));
                    }
			    }
				catch (FormatException e)
				{
					Console.WriteLine("Input was not a number.");
				}
				continue;
			}
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

			// 4- Write a program and ask the user to continuously enter a
			//  number or type "Quit" to exit. The list of numbers may 
			// include duplicates.Display the unique numbers that the user has 
			// entered.
			Console.WriteLine("Enter numbers or type 'quit.'");
            var inputList = new List<int>();
            var uniqueList = new List<int>();
			while (true)
			{
				Console.Write("Name:");
				var input4 = Console.ReadLine();
				if (input4 == "quit")
				{
					break;
				}
				try
				{
                    int inputAsInt = Convert.ToInt32(input4);
                    inputList.Add(inputAsInt);
                    if (uniqueList.Contains(inputAsInt) == false)
                    {
                        uniqueList.Add(inputAsInt);
                    }
				}
				catch (FormatException e)
				{
					Console.WriteLine("Input was not a number.");
				}
				continue;
			}
            foreach (var num in uniqueList)
            {
                Console.WriteLine(num);
            }

            // 5- Write a program and ask the user to supply a list of comma 
            // separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or  
            // includes less than 5 numbers, display "Invalid List" and ask the 
            // user to re-try; otherwise, display the 3 smallest numbers in the
            // list.
        }
    }
}
