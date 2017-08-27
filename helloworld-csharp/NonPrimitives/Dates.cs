using System;
namespace helloworldcsharp.NonPrimitives
{
    public class Dates
    {
        public static void Main()
        {
            // Creating Dates
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-M-d"));

            // Creating TimeSpans
            var timespan = new TimeSpan(1, 2, 3);

            var timespan1 = new TimeSpan(0, 0, 1);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = now.AddMinutes(2);
            var duration = start - end;
            Console.WriteLine("Duration:" + duration);

            // Properties
            Console.WriteLine(timespan.Minutes);

            // Add
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));

            // ToString
            Console.WriteLine(timespan.ToString());

            // Parse
            Console.WriteLine(TimeSpan.Parse("01:01:01"));

            var text = "TEXT";
            //text[0] = "5";

            Console.WriteLine(text);
        }
    }
}
