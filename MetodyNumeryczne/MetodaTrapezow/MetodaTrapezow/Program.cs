using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaTrapezow
{
    class Program
    {
        static double a = 0;
        static double b = Math.PI / 2.0;
        static double alfa0 = 1.0 / 2.0;
        static double alfa1 = 1.0 / 2.0;
        delegate double calkowanaFunkcja(double x);

        static void Main(string[] args)
        {
            calkowanaFunkcja f = Math.Cos;
            double wynik = (b - a) * (f(a) * alfa0 + f(b) * alfa1);

            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
