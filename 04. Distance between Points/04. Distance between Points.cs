using System;
using System.Linq;
namespace _04.Distance_between_Points
{
   public class Program
    {
       public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();
            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
            
        }
        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.x - second.x, 2);
            var squareY = Math.Pow(first.y - second.y, 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return new Point
            {
                x = pointParts[0],
                y = pointParts[1]
            };
        }
    }
}