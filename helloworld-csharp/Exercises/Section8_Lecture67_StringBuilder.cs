﻿using System;
using System.Text;
using System.Collections.Generic;

namespace helloworldcsharp.Exercises
{
    public class Section8_Lecture67_StringBuilder
    {
        public static void Main()
        {

            //1- Write a program and ask the user to enter a few numbers separated
            //by a hyphen. Work out if the numbers are consecutive. For example, 
            //if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
            //"Consecutive"; otherwise, display "Not Consecutive".
            Program1();




            //2- Write a program and ask the user to enter a few numbers separated
            //by a hyphen. If the user simply presses Enter, without supplying an 
            //input, exit immediately; otherwise, check to see if there are
            //duplicates. If so, display "Duplicate" on the console.



            //3- Write a program and ask the user to enter a time value in the 
            //24-hour time format (e.g. 19:00). A valid time should be between 
            //00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
            //display "Invalid Time". If the user doesn't provide any values, 
            //consider it as invalid time. 



            //4- Write a program and ask the user to enter a few words separated 
            //by a space. Use the words to create a variable name with PascalCase.
            //For example, if the user types: "number of students", display 
            //"NumberOfStudents". Make sure that the program is not dependent on 
            //the input. So, if the user types "NUMBER OF STUDENTS", the program 
            //should still display "NumberOfStudents".



            //5- Write a program and ask the user to enter an English word. Count 
            //the number of vowels (a, e, o, u, i) in the word. So, if the user 
            //enters "inadequate", the program should display 6 on the console
        }

        public static void Program1()
        {
			//1- Write a program and ask the user to enter a few numbers separated
			//by a hyphen. Work out if the numbers are consecutive. For example, 
			//if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
			//"Consecutive"; otherwise, display "Not Consecutive".
			StringBuilder sb = new StringBuilder();
			sb.Append("This is a test value.");

			Console.WriteLine(sb);
			Console.Write("Enter a bunch of numbers seperated by hyphens... or not:");
			string input2 = Console.ReadLine();
            var splitString = input2.Split('-'); // Don't forget " vs '
            if ((splitString.Length /  2) == 0) /** Means there are no "-" 
                                                 present in the input text. **/
            {
                Console.WriteLine((splitString.Length / 2));
            }
            else
            {
                Console.WriteLine("Even.");
            }
        }
    }
}
