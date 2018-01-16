using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 3;
            double PI = 3.14;
            double fraction = 1.33;
            int denominator = 2;

            double volumeHem = fraction * PI * radius * radius * radius / denominator;
            Console.WriteLine("Volume of a hemisphere= {0}", volumeHem);

        }
    }
}
