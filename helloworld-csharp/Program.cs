using System;

namespace helloworldcsharp
{
    public class Program
    {
		static void Main(string[] args)
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
    }
}
