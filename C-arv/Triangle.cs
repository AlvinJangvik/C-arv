﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }
        public override int Area()
        {
            int area = (width * height) / 2;
            return area;
        }

        public override int Circumference()
        {
            int Circ = width + height*2;
            return Circ;
        }
    }
}
