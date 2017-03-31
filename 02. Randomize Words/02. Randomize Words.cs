using System;
using System.Linq;
namespace _02.Randomize_Words
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var rnd = new Random();
            int num = rnd.Next(0, words.Length);
            for (int i = 0; i < words.Length - 1; i++) 
            {
                var temp = words[i];
                words[i] = words[num];
                words[num] = temp;
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}