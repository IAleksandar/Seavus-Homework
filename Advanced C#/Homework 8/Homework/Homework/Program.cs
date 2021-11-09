using Homework.Class;
using System;

namespace Homework
{
    class Program
    {
        public static Database _dogsDatabase = new Database();

        static void Parameters()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter color: ");
            string color = Console.ReadLine();
            Dog dog = new Dog(name, age, color);
            _dogsDatabase.Insert(dog);
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Would you like to enter a Dog ?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Parameters();
                }
                else if(answer == "no")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Wrong input !");
                    flag = false;
                }
            }


           





            Console.ReadLine();
        }
    }
}
