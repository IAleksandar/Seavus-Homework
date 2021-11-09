using Bonus.Class;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bonus
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() {FirstName = "Aleksandar", LastName ="Ivanovski", Age=26},
                new Person() {FirstName = "Elena", LastName ="Betinska", Age=21},
                new Person() {FirstName = "Marija", LastName ="Mladenovksa", Age=21},
                new Person() {FirstName = "Viktor", LastName ="Stojkov", Age=27},
                new Person() {FirstName = "Mila", LastName ="Velkovska", Age=22}
             };

            string appPath = @"..\..\..\";
            bool fileExists = File.Exists(appPath + @"People.txt");

            if (!fileExists)
            {
                File.Create(appPath + @"/People.txt").Close();
                Console.WriteLine("File created!");

                string filePath = appPath + @"People.txt";
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    foreach (Person person in people)
                    {
                        sw.WriteLine(person.PrintInfo());
                    }
                    Console.WriteLine("People are saved in the file!");
                }

                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine("=======================================");
                    List<Person> newList = new List<Person>();

                    foreach (Person person in people)
                    {
                        string firstLine = sr.ReadLine();
                        string[] name = firstLine.Split(" ");
                        bool success = int.TryParse(name[2], out int age);
                        if (success)
                        {
                            newList.Add(new Person() { FirstName = name[0], LastName = name[1], Age = age });
                        }
                    }
                    for (int i = 0; i < newList.Count; i++)
                    {
                        Console.WriteLine(newList[i].PrintInfo());
                    }
                }
            }

            Console.ReadLine();
        }
    }
}