using ClassLibrary1.Classes;
using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal(){Name = "Abby", Color = "Brown", Age = 5, Gender = GenderEnum.Male},
                new Animal(){Name = "Sparky", Color = "Black", Age = 7, Gender = GenderEnum.Male},
                new Animal(){Name = "Ollie", Color = "Black", Age = 5, Gender = GenderEnum.Female},
                new Animal(){Name = "Baron", Color = "White", Age = 2, Gender = GenderEnum.Male},
                new Animal(){Name = "Galapagosgiant", Color = "Purple", Age = 100, Gender = GenderEnum.Male},
                new Animal(){Name = "Redseaurchin", Color = "Orange", Age = 250, Gender = GenderEnum.Female},
                new Animal(){Name = "Acester", Color = "Brown", Age = 3, Gender = GenderEnum.Male}
            };

            Console.WriteLine("All the animals aged 5 or more");
            List<string> AgedFiveOrMore = animals.Where(x => x.Age >= 5).Select(x => $"{x.Name} {x.Age}").ToList();
            foreach(string ageFive in AgedFiveOrMore)
            {
                Console.WriteLine(ageFive);
            }

            Console.WriteLine("All the names of the animals that start with 'A'");
            List<Animal> namesStartWithA = animals.Where(x => x.Name.StartsWith("A")).ToList();
            foreach(Animal nameA in namesStartWithA)
            {
                Console.WriteLine(nameA.Name);
            }

            Console.WriteLine("All male and brown animals");
            List<Animal> maleBrown = animals.Where(x => x.Color == "Brown" && x.Gender == GenderEnum.Male).ToList();
            foreach(Animal brownMale in maleBrown)
            {
                Console.WriteLine($"{brownMale.Name} - {brownMale.Color} - {brownMale.Gender}");
            }

            Console.WriteLine("First animal whose name is longer than 10 characters");
            Animal nameLongerThanTen = animals.FirstOrDefault(x => x.Name.Length > 10);
            Console.WriteLine(nameLongerThanTen.Name);



            Console.ReadLine();
        }
    }
}
