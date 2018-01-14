using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaBisekcji
{
    class Program
    {
        static double epsilon = 0.000001;
        static double a;
        static double b;

        static void Main(string[] args)
        {
            // dla funkcji x^3 + 4 * x^2 - 10
            a = 1;
            b = 2;

            double szukana = 0;

            while (true)
            {
                szukana = (a + b) / 2;

                if(f(szukana) <= epsilon)
                {
                    break;
                }
                else if (f(szukana) * f(a) < 0)
                {
                    b = szukana;
                }
                else
                {
                    a = szukana;
                }
            }

            Console.WriteLine(szukana);
            Console.ReadLine();
        }

        static double f(double x)
        {
            return Math.Pow(x, 3) + Math.Pow(x, 2) * 4 - 10;
        }
    }
}
