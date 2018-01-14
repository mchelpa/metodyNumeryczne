using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSiecznych
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

            List<double> sieczne = new List<double>();
            sieczne.Add(a);
            sieczne.Add(b);

            int i = 1;
            while(true)
            {
                sieczne.Add(sieczne[i] - (f(sieczne[i])) * ((sieczne[i] - sieczne[i - 1]) / (f(sieczne[i]) - f(sieczne[i - 1]))));
                if (f(sieczne.Last()) < epsilon) break;
            }

            Console.WriteLine(sieczne.Last());
            Console.ReadLine();
        }

        static double f(double x)
        {
            return Math.Pow(x, 3) + Math.Pow(x, 2) * 4 - 10;
        }
    }
}
