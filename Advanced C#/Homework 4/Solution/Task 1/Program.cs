using ClassLibrary1.Classes;
using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDB<Shape>.Shapes.Add(new Circle() { Id = 1, Radius = 2.5 });
            GenericDB<Shape>.Shapes.Add(new Rectangle() { Id = 2, SideA = 3.6, SideB = 1.4 });
            foreach(Shape shape in GenericDB<Shape>.Shapes)
            {
                shape.PrintInfo();
            }
            GenericDB<Shape>.PrintAreas();
            GenericDB<Shape>.PrintPerimeters(); 




            Console.ReadLine();
        }
    }
}
