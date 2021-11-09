using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countries { get; set; }
        public Car(int id, string type, int year, int batch, int fuel, string country) : base(id, type, year, batch)
        {
            FuelTank = fuel;
            Countries = country;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"The car {Type} is produced in {Countries}");
        }
    }
}
