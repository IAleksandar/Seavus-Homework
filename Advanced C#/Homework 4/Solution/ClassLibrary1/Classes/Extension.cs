using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
        public static class Extension
        {
            public static void PrintInfo(this Shape shape)
            {
                if (shape.GetType().ToString() == "ClassLibrary1.Classes.Circle")
                {
                    Console.WriteLine($"Id: {shape.Id} Type: Circle");
                }
                else if (shape.GetType().ToString() == "ClassLibrary1.Classes.Rectangle")
                {
                    Console.WriteLine($"Id: {shape.Id} Type: Rectangle");
                }
            }
        }
}
