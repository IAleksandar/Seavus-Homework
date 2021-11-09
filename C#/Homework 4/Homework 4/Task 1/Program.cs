using System;
using Task_1.Classes_Library.Classes;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) { 
                Console.WriteLine("Car models and drivers: ");
                Console.WriteLine("1. Hyundai 2. Mazda 3. Ferrari 4. Porsche");
                Console.WriteLine("1. Bob 2. Greg 3.Jill 4. Anne");



            Driver[] drivers =
            {
                new Driver("Bob", 3),
                new Driver("Greg", 4),
                new Driver("Jill", 8),
                new Driver("Anne", 10)
            };

            Car[] cars =
            {
                new Car("Hyundai", 200),
                new Car("Mazda", 210),
                new Car("Ferrari", 250),
                new Car("Porsche", 300)
            };

            Car[] car1RaceObject = new Car[1];
            Car[] car2RaceObject = new Car[1];

            Console.WriteLine("Choose a car No.1: ");
            string car = Console.ReadLine();
            Console.WriteLine("Choose Driver: ");
            string name = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                if (car.ToLower() == cars[i].Model.ToLower())
                {
                    car1RaceObject[0] = cars[i];
                }
            }



            for (int i = 0; i < drivers.Length; i++)
            {
                if (name.ToLower() == drivers[i].Name.ToLower())
                {
                    car1RaceObject[0].Driver = drivers[i];
                }
            }

            Console.WriteLine("Choose a car No.2: ");
            string car2 = Console.ReadLine();
            Console.WriteLine("Choose Driver: ");
            string name2 = Console.ReadLine();

            for(int i = 0; i < cars.Length; i++)
            {
                if(car1RaceObject[0].Model.ToLower() == car2.ToLower())
                {
                    throw new Exception("You can not choose the same car model !");
                }

                if(car2.ToLower() == cars[i].Model.ToLower())
                {
                    car2RaceObject[0] = cars[i];
                }
            }

            for (int i = 0; i < drivers.Length; i++)
            {
                if(car1RaceObject[0].Driver.Name.ToLower() == name2.ToLower())
                {
                    throw new Exception("You can not choose the same driver !");
                }

                if(name2.ToLower() == drivers[i].Name.ToLower())
                {
                    car2RaceObject[0].Driver = drivers[i];
                }
            }

            RaceCars(car1RaceObject[0], car2RaceObject[0]);

             

            Console.WriteLine("Do you want to race again ? (y/n)");
            string input = Console.ReadLine();
            if(input.ToLower() == "n")
            {
                Console.Clear();
                break;
            }
            else if(input.ToLower() == "y")
            {
                    Console.Clear();
                    Console.WriteLine("You can start new race...");

                }
            else
            {
                    Console.Clear();
                    break;
            }

            static void RaceCars(Car car1, Car car2)
            {
                if(car1.CalculateSpeed(car1.Driver) > car2.CalculateSpeed(car2.Driver))
                {
                    Console.WriteLine($"The car model {car1.Model} with driver {car1.Driver.Name} won with {car1.Speed}km/h speed.");
                }
                else if (car2.CalculateSpeed(car2.Driver) > car1.CalculateSpeed(car1.Driver))
                {
                    Console.WriteLine($"The car model {car2.Model} with driver {car2.Driver.Name} won with {car2.Speed}km/h speed.");
                }
                else
                {
                    Console.WriteLine("Nobody won the race !");
                }
            }

            }



            Console.ReadLine();
        }

        
    }
}
