using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas
{
    class AreaAndCircumferenceOfCircle
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Pi: {0}", Math.PI);
            Console.ReadKey();*/
            /*int r;
            double A;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;
            Console.WriteLine("The area of a circle of given radius is=" + A);
            Console.ReadLine();*/
            /*float diameter = 2 * radius;
            Console.WriteLine("Diameter = {0:F2}", diameter);*/
            int radius = 3;
            float PI = 3.14f;

            float area = PI * radius * radius;
            Console.WriteLine("Area = {0}", area);

            float circumference = 2 * PI * radius;
            Console.WriteLine("Circumference = {0}", circumference);
        }
    }
}
/*
     Output:
 
     Area = 28.26
     Diameter = 6.00
     Circumference = 18.84
*/
