using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaker
{
    internal class Elipse: Shape
    {
        public Elipse(Point p1, int width, int height)
        {
            P1 = p1;
            Width = width;
            Height = height;
        }

        public Point P1;
        public int Width;
        public int Height;

        public override string Draw()
        {
            return $"Elipse: ({P1.X}, {P1.Y}, {Width}, {Height})";
        }
    }
}
