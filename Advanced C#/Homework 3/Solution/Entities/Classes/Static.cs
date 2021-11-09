using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Classes
{
    public static class Static
    {
        public static List<Vehicle> vehicles { get; set; }
        public static List<Car> cars { get; set; }
        public static List<Bike> bikes { get; set; }
        static Static()
        {
            Vehicle vehicle1 = new Vehicle(0, "Car", 1999, 526);
            Vehicle vehicle2 = new Vehicle(2, "Bike", 1990, 555);
            Vehicle vehicle3 = new Vehicle(3, "Car", 1998, 666);

            Car car1 = new Car(4, "Car", 2020, 666, 50, "Japan");
            Car car2 = new Car(5, "Car", 2015, 111, 45, "Germany");
            Car car3 = new Car(6, "Car", 1996, 222, 65, "America");

            Bike bike1 = new Bike(7, "Bike", 2000, 123, "white");
            Bike bike2 = new Bike(8, "Bike", 2001, 132, "black");
            Bike bike3 = new Bike(9, "Bike", 2002, 321, "blue");

            vehicles = new List<Vehicle>() { vehicle1, vehicle2, vehicle3 };
            cars = new List<Car>() { car1, car2, car3 };
            bikes = new List<Bike>() { bike1, bike2, bike3 };

        }
    }
}
