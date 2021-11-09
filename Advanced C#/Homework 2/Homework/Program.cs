using Homework.Classes;
using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Sparky", 5, "black", true, "bulldog", false);
            Dog dog2 = new Dog("Sarko", 2, "white", false, "greyhound", false);

            Cat cat1 = new Cat("Garfield", 1, "orange", true, "black", true);
            Cat cat2 = new Cat("Lucy", 3, "black", false, "white", false);

            dog1.Bark();
            cat1.Eat("cat food");
            dog2.PrintAnimal();

            List<Animal> animals = new List<Animal>()
            {
                new Dog("Ollie", 3, "brown", true, "golden retriever", true),
                new Dog("Ozzy", 2, "black", true, "poodle", false),
                new Cat("Jack", 1, "white", false, "blue", true),
                new Cat("Jack", 5, "orange", false, "black", false)
            };

            try
            {
                if (animals != null)
                {
                    foreach (Animal animal in animals)
                    {
                        if (animal.GetType() == dog1.GetType())
                        {
                            ((Dog)animal).Bark();
                        }

                        else if (animal.GetType() == cat1.GetType())
                        {
                            ((Cat)animal).Eat("cat food");
                        }
                        else
                        {
                            throw new Exception("You have entered invalid information or other type of animal!");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
