using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public static class GenericDB<T> where T : Shape
    {
        public static List<T> Shapes { get; set; }
        static GenericDB()
        {
            Shapes = new List<T>(); 
        }

        public static void PrintAreas()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine($"The area is: {shape.GetArea()}");
            }
        }
        public static void PrintPerimeters()
        {
            foreach(T shape in Shapes)
            {
                Console.WriteLine($"The perimeter is: {shape.GetPerimeter()}");
            }
        }

    }
}
