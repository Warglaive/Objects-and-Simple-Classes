using System;
using System.Linq;
namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        public decimal Top { get; set; }
        public decimal Left { get; set; }
        public decimal Right { get; set; }
        public decimal Bottom { get; set; }
        public string Print()
        {
            return $"{Top}, {Left}, {Right}, {Bottom}";
        }
    }
    public class Program
    {
        public static void Main()
        {
            var r1 = ReadRectangle();
            var r2 = ReadRectangle();
            IsInside(r1, r2);
        }
        public static void IsInside(Rectangle r1, Rectangle r2)
        {
            var inside = false;
            if (r1.Left >= r2.Left
                && r1.Right <= r2.Right
                && r1.Top <= r2.Top
                && r1.Bottom <= r2.Bottom)
            {
                inside = true;
            }
            if (inside == false)
            {
                Console.WriteLine("Not inside");
            }
            else
            {
                Console.WriteLine("Inside");
            }
        }
        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Right = rectangleParts[2],
                Bottom = rectangleParts[3]
            };
        }
    }
}