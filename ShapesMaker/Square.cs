using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaker
{
    internal class Square : Shape
    {
        public Square(Point p1, Point p2, Point p3, Point p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }

        public Point P1;
        public Point P2;
        public Point P3;
        public Point P4;

        public override string Draw()
        {
            return $"Square: ({P1.X}, {P1.Y}, {P2.X}, {P2.Y}, {P3.X}, {P3.Y}, {P4.X}, {P4.Y})";
        }

    }
}
