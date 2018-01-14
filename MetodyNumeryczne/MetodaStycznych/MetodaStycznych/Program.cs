using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaStycznych
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;

            for(int i = 0; i < 1000; i++)
            {
                b = a - (f(a) / pochodnaF(a));
                a = b;
            }

            Console.WriteLine(b);
            Console.ReadLine();
        }

        static double f(double x)
        {
            return Math.Pow(x, 3) + Math.Pow(x, 2) * 4 - 10;
        }

        static double pochodnaF(double x)
        {
            return Math.Pow(x, 2) * 3 + x * 8;
        }
    }
}
