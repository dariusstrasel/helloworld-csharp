using System;

namespace helloworldcsharp
{
    public class Program
    {
		static void program(string[] args)
		{
			Console.WriteLine("Test3");

            // Creating a new object in memory:
            // Note: Object is a memory reference for a class.
			NonPrimitives.Person person = new NonPrimitives.Person();
            person.Name = "Melissa";
            person.Introduce();

            // Static Modifer:
            int sum = NonPrimitives.Calculator.Add(1, 2);


		}

        static void ReferenceValueTypes()
        {
            // Reference Types vs Value Types:
            // Value Types: Structures
            // - Allocated on stack
            // - Memory allocation done automatically

            // Reference Types: Class
            // - You need to allocate memory
            // - Memory located on heap
            // - Garbage collected by CLR 

            // Value Types:
            var a = 10;
            var b = a; // Has different memory address than a.
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            // Reference Types:
            var array1 = new int[3] {1,2,3}; // array1 creates a refernce on the stack to a memory address to the heap.
            var array2 = array1; // array2 creates a refernce on the stack to a memory address to the heap; sae as array1.

			array2[0] = 0;
            Console.WriteLine("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]);

            // Immutability vs Reference Types
            var number = 1;
            Increment(number); // This value will be created and immediately destroyed.
            Console.WriteLine("number: {0}", number);

            var person = new Person() { Age = 30 };
            MakeOld(person); // Passing person reference will successfully increment their age.
            Console.WriteLine(person.Age);
        }
        public class Person
        {
            public int Age;
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
