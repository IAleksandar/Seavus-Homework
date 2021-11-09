using Entities.Classes;
using System;

namespace Homework
{
    class Program
    {
        public static void PrintVehicle()
        {
            for (int i = 0; i < Static.vehicles.Count; i++)
            {
                Static.vehicles[i].PrintVehicle();
                Validator.Validate(Static.vehicles[i]);
            }
            for (int i = 0; i < Static.cars.Count; i++)
            {
                Static.cars[i].PrintVehicle();
                Validator.Validate(Static.cars[i]);
            }
            for (int i = 0; i < Static.bikes.Count; i++)
            {
                Static.bikes[i].PrintVehicle();
                Validator.Validate(Static.bikes[i]);
            }
        }
        static void Main(string[] args)
        {

            PrintVehicle();




            Console.ReadLine();
        }
    }
}
