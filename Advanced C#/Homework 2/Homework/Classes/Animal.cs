using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public bool IsLazy { get; set; }
        public Animal(string name, int age, string color, bool isLazy)
        {
            Name = name;
            Age = age;
            Color = color;
            IsLazy = isLazy;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"Animal's name is: {Name}. It is {Age} years old. Its color is: {Color}. Is lazy: {IsLazy}");
        }
    }
}
