using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in höjd");
            int höjd = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in bredd");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Triangel(1) eller Rektangel(2)?");
            int val = int.Parse(Console.ReadLine());

            IShape shape = new Rectangle(0,0);

            if(val == 1)
            {
                shape = new Triangle(bredd, höjd);
            }
            else if (val == 2)
            {
                shape = new Rectangle(bredd, höjd);
            }
            
            Console.WriteLine("Area: " + shape.Area());
            Console.WriteLine("Omkrets: " + shape.Circumference());
        }

    }
}
