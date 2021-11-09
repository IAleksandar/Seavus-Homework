using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }
        public Vehicle(int id, string type, int year, int batch)
        {
            Id = id;
            Type = type;
            YearOfProduction = year;
            BatchNumber = batch;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"Vehicle with id {Id} and type {Type} its made in {YearOfProduction}");
        }
    }
}
