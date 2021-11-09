using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Classes
{
    public class Dog : Animal, IDog
    {
        public string Race { get; set; }
        public bool IsHappy { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark !");
        }
        public Dog(string name, int age, string color, bool isLazy, string race, bool isHappy) : base(name, age, color, isLazy)
        {
            Race = race;
            IsHappy = isHappy;
        }
    }

}
