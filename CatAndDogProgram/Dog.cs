using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }
        public bool IsAsleep { get; set; }
        public bool HasEaten { get; set; }

        public void GoToSleep()
        {
            if (HasEaten)
            {
                IsAsleep = true;
            }
            else
            {
                IsAsleep = false;
            }
        }
        public void Eat(Cat cat)
        {
            if (cat != null)
            {
                HasEaten = true;
            }
        }
    }
}
