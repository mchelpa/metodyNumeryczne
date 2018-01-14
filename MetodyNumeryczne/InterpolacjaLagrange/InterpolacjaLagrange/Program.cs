using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacjaLagrange
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
        static List<Point> cosList = new List<Point>();
        static int stopien;
        static double wartoscSzukana = 1.15;
        static void Main(string[] args)
        {
            cosList.Add(new Point(1, Math.Cos(1)));
            stopien = 1;
            for (double i = 1.1; i <= 2.1; i += 0.1)
            {
                cosList.Add(new Point(i, Math.Cos(i)));
                Console.WriteLine(calculateLagrange() + " Langrange stopnia " + stopien);
                stopien += 1;
            }

            Console.ReadLine();
        }


        static double calculateLagrange()
        {
            double result = 0;
            for (int i = 0; i <= stopien; i++)
            {
                double tempVal = 1;
                for (int j = 0; j < cosList.Count; j++)
                {
                    if (i != j)
                    {
                        tempVal *= (wartoscSzukana - cosList[j].X) / (cosList[i].X - cosList[j].X);
                    }
                }
                result += tempVal * cosList[i].Y;
            }

            return result;
        }
    }
}
