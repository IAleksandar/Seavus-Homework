using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Classes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return 2 * Radius * 3.14;
        }

        public override double GetPerimeter()
        {
            return Radius * Radius * 3.14;
        }
    }
}
