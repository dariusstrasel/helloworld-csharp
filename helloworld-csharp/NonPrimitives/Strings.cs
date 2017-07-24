﻿using System;
namespace helloworldcsharp.NonPrimitives
{
    public class Strings
    {
        public void StringsMain()
        {
            // String: Sequence of characters. Characters are surrounded by single quotes.
            // Note: Strings are immutable.
            // String Literal:
            string firstName = "Darius";
            string lastName = "Strasel";

            // String concatenation:
            string name = firstName + " " + lastName;

            //String format:
            var fullName = string.Format("{0} {1}", firstName, lastName);

            // String Join:
            var numbers = new int[3] { 1, 2, 3 };
            var listOfNumbers = string.Join(",", numbers);

            // Verbatim strings, aka @ decorator:
            // \n : NewLine
            // \t : Tab
            // \\ : Escaped Backslash
            // The follwoing string is messy:
            string path = "c:\\projects\\project1\\folder1";
            // Use @ decorator:
            string path_2 = @"c:\projects\project1\folder1";

            // Can import System namespace and use primitive structs directly:
            String whyWouldYouDoThis = "lol";
            Int32 integer = 4;
        }
    }
}
