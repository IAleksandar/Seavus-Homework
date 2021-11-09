using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if(vehicle.Id != 0 && !string.IsNullOrEmpty(vehicle.Type) && vehicle.YearOfProduction != 0)
            {
                Console.WriteLine("Validation has been succeeded");
            }
            else
            {
                Console.WriteLine("Validation error!!!");
            }
        }
    }
}
