using System;
using System.Numerics;
namespace _03.Big_Factorial
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}