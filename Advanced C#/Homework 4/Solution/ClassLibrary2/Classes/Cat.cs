using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int lives) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = lives;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Is the cat lazy ? {Lazy}. It has {LivesLeft} lives left");
        }
    }
}
