using System;
namespace helloworldcsharp.Exercises
{
    public class Section5_Lecture42_Conditionals
    {
        public static void program()
        {
            // Program 1:
            // Write a program and ask the user to enter a number. The number 
            // should be between 1 to 10. If the user enters a valid number, 
            // display "Valid" on the console. Otherwise, display "Invalid". 
            // (This logic is used a lot in applications where values entered into 
            // input boxes need to be validated.)

            int number = 11;

            if (number <=10 && number >=1)
            {
                Console.WriteLine("Valid.");
            }
            else 
            {
                Console.WriteLine("Invalid.");
            }

            // Program 2:
            // Write a program which takes two numbers from the console and 
            // displays the maximum of the two.
            int number1 = 5;
            int number2 = 7;
            string context = "{0} ({1}) is greater than {2} ({3})";
            string message;

            if (number1 > number2)
            {
                message = string.Format(context, "number1", number1, "number2", number2);
            }
            else
            {
                message = string.Format(context, "number2", number2, "number1", number1);
            }
            Console.WriteLine(message);

            // Program 3:
            // Write a program and ask the user to enter the width and height 
            // of an image. Then tell if the image is landscape or portrait.

            int length = 500;
            int height = 750;

            if (length < height)
            {
                Console.WriteLine("Image is in portrait mode.");
            } 
            else
            {
                Console.WriteLine("Image is in landscape mode.");
            }

            // Program 4:
            // Your job is to write a program for a speed camera. 
            // For simplicity, ignore the details such as camera, sensors, etc 
            // and focus purely on the logic. Write a program that asks the 
            // user to enter the speed limit. Once set, the program asks for 
            // the speed of a car. If the user enters a value less than the 
            // speed limit, program should display Ok on the console. If the 
            // value is above the speed limit, the program should calculate the 
            // number of demerit points. For every 5km/hr above the speed limit, 
            // 1 demerit points should be incurred and displayed on the console. 
            // If the number of demerit points is above 12, the program should 
            // display License Suspended.
            Random rnd = new Random();
            int speedLimit = rnd.Next(25, 75);
            int carSpeed = rnd.Next(10, 200);
            int speedOverflow = carSpeed - speedLimit;
            int demeritPoints = speedOverflow / 5;
            string carMessage;

            // Program 4 Start:
            if (carSpeed <= speedLimit)
            {
                carMessage = "Ok.";
            }
            else if (demeritPoints > 12)
            {
                carMessage = "License Suspended.";
            }
            else
            {
                carMessage = string.Format("{0} mph over the speed limit. {1} Demerit Points.", speedOverflow, demeritPoints);
            }
            Console.WriteLine(string.Format("limit: {0}, speed: {1}", speedLimit, carSpeed));
            Console.WriteLine(carMessage);
        }
    }
}
