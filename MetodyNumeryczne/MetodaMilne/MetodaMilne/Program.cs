using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaMilne
{
    class Program
    {
        static double a = 0;
        static double b = Math.PI / 2.0;
        static double[] alfa = {
            7.0 / 90.0,
            32.0 / 90.0,
            12.0 / 90.0,
            32.0 / 90.0,
            7.0 / 90.0
        };
        delegate double calkowanaFunkcja(double x);

        static void Main(string[] args)
        {
            calkowanaFunkcja f = Math.Cos;

            double wynik = 0;
            double h = (b - a) / 4;
            double x = a;

            double suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += alfa[i] * f(x);
                x = x + h;
            }

            wynik = (b - a) * suma;

            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
