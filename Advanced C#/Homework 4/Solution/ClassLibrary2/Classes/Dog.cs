using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2.Classes
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }
        public Dog(string name, string type, int age, string fav) : base(name, type, age)
        {
            FavouriteFood = fav;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Dogs favourite food is: {FavouriteFood}");
        }
    }
}
