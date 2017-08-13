using System;
namespace helloworldcsharp.NonPrimitives
{
    public class Arrays
    {
        public void program(string[] args)
        {
            var numbers = new int[3]; 
            // Access array elements by passing index to braces
            // All primitives inside array must be the same data type.
            numbers[0] = 1;

            // Object initilization syntax:
            var names = new string[3] { "Jack", "John", "Mary" };

            // Arrays Part 2:

            var numbers2 = new int[] { 1, 2, 3, 4, 5, 6 };

            // Length
            Console.WriteLine(numbers2.Length);

            // IndexOf()
            Console.WriteLine(Array.IndexOf(numbers2, 9));

            // Clear
            Array.Clear(numbers2, 0, 2); // 0: array, 1: index to start, 2: number of items to remove

            Console.WriteLine("Effect of Array.Clear()");
            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }

            // Copy
            Console.WriteLine("Effect of Array.Copy()");

            var another = new int[3];  
            Array.Copy(numbers2, numbers, 3);

            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort
            Array.Sort(numbers2);

            Console.WriteLine("Effect of Array.Sort()");
            foreach(var n in numbers2)
            {
                Console.WriteLine(n);
            }

            // Reverse
            Array.Reverse(numbers2);

            foreach (var n in numbers2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
