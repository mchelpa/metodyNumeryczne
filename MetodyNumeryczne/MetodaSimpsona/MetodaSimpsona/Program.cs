using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSimpsona
{
    class Program
    {
        static double a = 0;
        static double b = Math.PI / 2.0;
        static double[] alfa = {
            1.0 / 3.0,
            4.0 / 3.0,
            1.0 / 3.0
        };
        delegate double calkowanaFunkcja(double x);

        static void Main(string[] args)
        {
            calkowanaFunkcja f = Math.Cos;
            double[] fx =
            {
                f(a),
                f((b + a) / 2),
                f(b)
            };
            double wynik;
            double przedNawiasem = (b - a) / 2;
            double kwadratowyNawias = 0;

            for(int i = 0; i < 3; i++)
            {
                kwadratowyNawias += fx[i] * alfa[i];
            }


            wynik = przedNawiasem * kwadratowyNawias;

            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
