using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Triangle : IShape
    {
        private int width;
        private int height;
        public Triangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public int Area()
        {
            int area = width * height;
            return area;
        }

        public int Circumference()
        {
            int Circ = width + height*2;
            return Circ;
        }
    }
}
