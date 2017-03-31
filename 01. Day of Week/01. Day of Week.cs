using System;
using System.Globalization;
namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(result.DayOfWeek);
        }
    }
}