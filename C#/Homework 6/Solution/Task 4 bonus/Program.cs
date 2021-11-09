using System;
using System.Collections.Generic;
using Task_4_bonus.Class;

namespace Task_4_bonus
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Elena", LastName = "Betinska", Age = 21},
                new Employee(){FirstName = "Aleksandar", LastName = "Ivanovski", Age = 26},
                new Employee(){FirstName = "Viktor", LastName = "Stojkov", Age = 26},
                new Employee(){FirstName = "Marija", LastName = "Mladenovska", Age = 21},
                new Employee(){FirstName = "Danilo", LastName = "Borozan", Age = 21},
                new Employee(){FirstName = "Tamara", LastName = "Maksimovska", Age = 30},
                new Employee(){FirstName = "Mila", LastName = "Velkovska", Age = 22},
                new Employee(){FirstName = "Andrej", LastName = "Ivanov", Age = 23},
                new Employee(){FirstName = "Kristina", LastName = "Lazoroska", Age = 31},
                new Employee(){FirstName = "Stefanija", LastName = "Micevska", Age = 25}
            };

            Dictionary<int, List<string>> myDictionary = new Dictionary<int, List<string>>();

            foreach(var person in employees)
            {
                if (myDictionary.ContainsKey(person.Age))
                {
                    List<string> fullNames = myDictionary[person.Age];
                    fullNames.Add($"{person.FirstName} {person.LastName}");

                }
                else
                {
                    myDictionary.Add(person.Age, new List<string> { $"{person.FirstName} {person.LastName}"});
                }
            }

            foreach(var element in myDictionary)
            {
                Console.WriteLine(element.Key);
                foreach(var name in element.Value)
                {
                    Console.WriteLine(name);
                }
            }

            Console.ReadLine();
        }
    }
}
