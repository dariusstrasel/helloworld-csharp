using System;
namespace helloworldcsharp.Primitives
{
    public class Handler
    {
		static void PrimitiveTypes()
		{
			// Hello World
			Console.WriteLine("Hello world.");

			// Variable Types
			// Primitives
			byte number = 5;
			int count = 2;
			float cash = 3.4f; // Floats have 'f' on end to indicate they be a float, as opposed to a double.
			char character = 'A'; // Single quotes for char data types.
			bool isWorking = true;
			// Not primitive
			string firstName = "Darius"; // Double quotes for string data types. Note: string is not a primitive

			// Stdout printing...
			Console.WriteLine(number);
			Console.WriteLine(count);
			Console.WriteLine(cash);
			Console.WriteLine(character);
			Console.WriteLine(firstName);
			Console.WriteLine(isWorking);

			// Template Strings:
			Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
		}
		static void TypeConversion()
		{
			// Constants
			const float Pi = 3.14f;
			Console.WriteLine(Pi);

			// Implicit typing:
			var implicitType = "banana";
			Console.WriteLine(implicitType);

			// Implicit type conversion
			byte b = 1; // 00000001
			int i = b; // 00000000 00000000 00000000 00000001

			int i_copy = 1;
			float f = i_copy;

			// Explicit type conversion
			int i_copy_2 = 1;
			byte b_copy = (byte)i_copy_2; // casting int to byte

			float f_copy = 1.0f;
			int i_copy_3 = (int)f_copy; // float to byte, there IS data loss

			string s_copy = "1";
			// The following line won't compile, because string > int does not work
			// int i_copy_4 = (int)s_copy;

			// Can solve using Convert class, or Parse method:
			// Convert: .net framework method, converts to .net IL data type
			// Includes: ToByte(), ToInt16(), ToInt32(), ToInt64()
			// Parse: 
			int i_copy_4 = Convert.ToInt32(s_copy); // Int32 means '32' bytes, or a primitive integer
			int j = int.Parse(s_copy);
		}
		static void TryExceptCatch()
		{
			// Try / Catch exception block.
			try
			{
				var number_copy = "1234";
				byte b_copy_2 = Convert.ToByte(number_copy);
				Console.WriteLine(b_copy_2);
			}
			catch (Exception ex)
			{
				Console.WriteLine("The number could not be converted to a byte.");
			}
		}
		static void Operators()
		{
			// 
			var a = 10;
			var b = 3;

			// Add
			Console.WriteLine(a + b);
			// Division
			Console.WriteLine(a / b);
			// Dvision w/ floats
			Console.WriteLine((float)a / (float)b);

			var a_ex = 1;
			var b_ex = 2;
			var c_ex = 3;
			// W/o Operator Precidence:
			Console.WriteLine(a_ex + b_ex * c_ex);
			// With Operator Precidence:
			Console.WriteLine((a_ex + b_ex) * c_ex);

			// Comparison Operators
			Console.WriteLine(a > b);
			// >, <, ==, !=, !, &&, ||
		}
		static void Comments()
		{
			// <- Single Line Comment
			/* <- Multi Line Comment


            */
		}
    }
}
