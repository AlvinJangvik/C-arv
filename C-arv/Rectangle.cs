using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Rectangle
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
        }
        public int Area()
        {
            int area = width * height;
            return area;
        }

        public int Circumference()
        {
            int Circ = width*2 + height*2;
            return Circ;
        }
    }
}
