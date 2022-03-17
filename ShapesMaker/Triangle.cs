using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaker
{
    internal class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public Point P1;
        public Point P2;
        public Point P3;

        public override string Draw()
        {
            return $"Triangle: ({P1.X}, {P1.Y}, {P2.X}, {P2.Y}, {P3.X}, {P3.Y})";
        }
    }

}
