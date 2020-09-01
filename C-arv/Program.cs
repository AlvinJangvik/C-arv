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

            Triangle tri = new Triangle(bredd, höjd);
            Console.WriteLine("Omkrets: ", tri.Circumferance());
            Console.WriteLine("Area: ", tri.Area());
        }

    }
}
