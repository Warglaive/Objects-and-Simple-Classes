﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string SayHallo()
        {
            return $"hi i am {Name} {Age} years old";
        }
    }
}
