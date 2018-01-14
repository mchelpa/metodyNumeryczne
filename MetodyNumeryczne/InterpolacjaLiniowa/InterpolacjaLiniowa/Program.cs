using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacjaLiniowa
{
    class Program
    {
        class Point
        {
            public double X;
            public double Y;
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        static double val1 = 1.1;
        static double val2 = 1.2;

        static Point firstPoint = new Point(val1, Math.Cos(val1));
        static Point secondPoint = new Point(val2, Math.Cos(val2));
        static double argumentX = 1.15;

        static void Main(string[] args)
        {
            double result = firstPoint.Y + (secondPoint.Y - firstPoint.Y) / (secondPoint.X - firstPoint.X) * (argumentX - firstPoint.X);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
