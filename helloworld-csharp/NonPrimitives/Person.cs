using System;
namespace helloworldcsharp.NonPrimitives
{
	public class Person
	{
		public string Name = "Darius";
		public void Introduce() // Returns nothing
		{
			Console.WriteLine("Hi, my name is {0}.", this.Name); // Prints it's name.
		}
	}
}
