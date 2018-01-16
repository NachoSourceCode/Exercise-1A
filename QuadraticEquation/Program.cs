using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            //Extra comment.
            double a = 1;
            double b = 6;
            double c = -16;

            // Everything under the sqrt in the numerator
            double underSqrt = Math.Pow(b, 2) - (4 * a * c);

            //if values listed under the square root evalute to > 0, the code will execute the statements listed
            //within the curly braces. In other words...not a negative number.
            if (underSqrt > 0)
            {
                double denominator = (2 * a);
                double left = (-b) / denominator;
                double right = Math.Sqrt(underSqrt) / denominator;

                double x1 = left + right;
                double x2 = left - right;

                Console.WriteLine("Solutions: {0} and {1}.", x1, x2);
            }
            //only if the if statement evalutes to false.
            else
            {
                Console.WriteLine("You provided variables that couldn't be calculated under the square root.");
            }
        }
    }
}
/* By: Elliot Robinson */
