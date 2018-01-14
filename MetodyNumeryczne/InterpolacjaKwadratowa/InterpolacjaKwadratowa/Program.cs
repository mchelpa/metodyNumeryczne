using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacjaKwadratowa
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

        static double val0 = 1.0;
        static double val1 = 1.1;
        static double val2 = 1.2;

        static Point firstPoint = new Point(val0, Math.Cos(val0));
        static Point secondPoint = new Point(val1, Math.Cos(val1));
        static Point thirdPoint = new Point(val2, Math.Cos(val2));

        static double argumentX = 1.15;

        static void Main(string[] args)
        {
            double l0 = ((argumentX - secondPoint.X) * (argumentX - thirdPoint.X)) / ((firstPoint.X - secondPoint.X) * (firstPoint.X - thirdPoint.X));
            double l1 = ((argumentX - firstPoint.X) * (argumentX - thirdPoint.X)) / ((secondPoint.X - firstPoint.X) * (secondPoint.X - thirdPoint.X));
            double l2 = ((argumentX - firstPoint.X) * (argumentX - secondPoint.X)) / ((thirdPoint.X - firstPoint.X) * (thirdPoint.X - secondPoint.X));

            double result = l0 * firstPoint.Y + l1 * secondPoint.Y + l2 * thirdPoint.Y;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
