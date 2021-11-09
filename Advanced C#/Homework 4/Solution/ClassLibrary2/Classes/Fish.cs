using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public double Size { get; set; }
        public Fish(string name, string type, int age, string color, double size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"This fish is {Color} and has size {Size}");
        }
    }
}
