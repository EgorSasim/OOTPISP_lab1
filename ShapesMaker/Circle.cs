using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaker
{
    internal class Circle :Shape
    {
        public Circle(Point p1, int diameter)
        {
            P1 = p1;
            Diameter = diameter;
        }

        public Point P1;
        public int Diameter;

        public override string Draw()
        {
            return $"Circle: ({P1.X}, {P1.Y}, {Diameter})";
        }

    }
}
