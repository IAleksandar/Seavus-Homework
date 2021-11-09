using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
