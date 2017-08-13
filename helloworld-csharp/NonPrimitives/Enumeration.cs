using System;
namespace helloworldcsharp.NonPrimitives
{
    public enum ShippingMethod
    // A set of name/value pairs (constants)
    // Looks like an Object in Python or Javascript plus constants as keys.
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Program {
		public static void program()
		{
			var method = ShippingMethod.Express;

			// Cast enum to integer:
			Console.WriteLine((int)method);

			// Reverse enumeration:
			byte methodId = 3;
			Console.WriteLine((ShippingMethod)methodId);

			// Get method as a string:
			// Note: Console.WriteLine() converts arguments using ToString()
			Console.WriteLine(method.ToString());

			// Convert string back into enumerator:
			var methodName = "Express";
			var shippingMethod = (ShippingMethod)Enum.Parse(typeof(int), methodName);
		}   
    }
}
