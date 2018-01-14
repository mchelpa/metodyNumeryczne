using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSimpsonaZlozona
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
            double x = a;
            double n = 100;
            double h = (b - a) / n;

            double suma = f(a);
            for (int i = 1; i < n; i++)
            {
                //Console.WriteLine(f(a + i * h));
                if(i % 2 == 0)
                {
                    suma += 2 * f(a + i * h);
                }
                else
                {
                    suma += 4 * f(a + i * h);
                    //Console.WriteLine("kom");
                }
            }
            suma += f(b);

            wynik = (h / 3) * suma;

            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
