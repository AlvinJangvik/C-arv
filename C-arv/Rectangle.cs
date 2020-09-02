using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }
        public override int Area()
        {
            int area = width * height;
            return area;
        }

        public override int Circumference()
        {
            int Circ = width + height;
            return Circ;
        }
    }
}
