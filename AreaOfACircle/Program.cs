using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c = 3;
            int denominator = 2;

            // calculate half the circumfernce of a triangle(semi perimeter), p = (a + b + c) / 2
            double sp = (a + b + c) / denominator;
            Console.WriteLine("Half the circumference of a triangle: {0}", sp);

            // calculate area of circle, A = sqrt of p (p-a) (p-b) (p-c)
            double areaOfATriangle = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            Console.WriteLine("Area of a Triangle: {0}", areaOfATriangle);
        }
    }
}
