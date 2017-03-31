using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public string Print()
        {
            return $"({x}, {y})";
        }
    }
   public class Program
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }
            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;
            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first+1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = Distance(firstPoint, secondPoint);
                    if (distance < minimumDistance) 
                    {
                        minimumDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minimumDistance:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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
        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.x - second.x, 2);
            var squareY = Math.Pow(first.y - second.y, 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
    }
}