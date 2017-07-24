using System;
namespace helloworldcsharp.NonPrimitives
{
    public class Arrays
    {
        public void Main(string[] args)
        {
            var numbers = new int[3]; 
            // Access array elements by passing index to braces
            // All primitives inside array must be the same data type.
            numbers[0] = 1;

            // Object initilization syntax:
            var names = new string[3] { "Jack", "John", "Mary" };

        }
    }
}
