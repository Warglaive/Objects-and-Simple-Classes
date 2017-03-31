using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    public class Program
    {
        public static void Main()
        {
            var dog = new Dog
            {
                Name = "Sharo",
                Age = 15,
                Breed = "Street Perfect",
                IsAsleep = false,
                HasEaten = false
            };
            dog.GoToSleep();
            dog.Eat(null);
            dog.GoToSleep();
            Console.WriteLine(dog.IsAsleep);
            var cat = new Cat()
            {
                Name = "Kitty",
                Age = 2,
                Color = "black"
            };
            dog.Eat(cat);
            dog.GoToSleep();
            Console.WriteLine(dog.IsAsleep);
        }
    }
}
