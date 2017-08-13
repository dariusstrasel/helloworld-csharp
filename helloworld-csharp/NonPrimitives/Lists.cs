using System;
using System.Collections;
using System.Collections.Generic;

namespace helloworldcsharp.NonPrimitives
{
    public class Lists
    {
        public static void lists()
        {
            // Lists are a 'generic' data type. The <int> specifices the input arg.
            var numbers = new List<int>() {1,2,3,4,5,6};

            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.IndexOf(1);
            numbers.LastIndexOf(1);
            //numbers.Count;
            numbers.Remove(1);

            // must use for(var i;1<x;i++) as opposed to foreach... because it raises ane xception
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Clear();
            //numbers.Count
        }
    }
}
