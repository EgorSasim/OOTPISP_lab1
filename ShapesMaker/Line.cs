using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaker
{
    internal class Line : Shape
    {
        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;  
        }

        Point P1;
        Point P2;

        public override string Draw()
        {
            return $"Line: ({P1.X}, {P1.Y} {P2.X} {P2.Y})";
        }
    }
}
