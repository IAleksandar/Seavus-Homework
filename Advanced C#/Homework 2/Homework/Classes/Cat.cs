using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Classes
{
    public class Cat : Animal, ICat
    {
        public string EyeColor { get; set; }
        public bool HasOwner { get; set; }
        public Cat(string name, int age, string color, bool isLazy, string eyeColor, bool hasOwner) : base(name, age, color, isLazy)
        {
            EyeColor = eyeColor;
            HasOwner = hasOwner;
        }
        public void Eat(string food)
        {
            Console.WriteLine($"This cat eats {food}");
        }
    }
}
