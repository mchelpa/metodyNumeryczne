using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacjaNewton
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
        static double wartoscSzukana = 1.05;
        static void Main(string[] args)
        {
            cosList.Add(new Point(1, Math.Cos(1)));
            stopien = 1;
            for (double i = 1.1; i <= 2.1; i += 0.1)
            {
                cosList.Add(new Point(i, Math.Cos(i)));
                Console.WriteLine(calculateNewton() + " Newton stopnia " + stopien);
                stopien += 1;
            }

            Console.ReadLine();
        }


        static double calculateNewton()
        {
            List<Point> tempCos = new List<Point>();

            foreach (Point p in cosList)
            {
                tempCos.Add(new Point(p.X, p.Y));
            }

            for(int i = 0; i < stopien - 1; i++)
            {
                for(int j = stopien - 1; j > i; j--)
                {
                    tempCos[j].Y = (tempCos[j].Y - tempCos[j - 1].Y) / (tempCos[j].X - tempCos[j - i - 1].X);
                }
            }

            double mult;
            double sum = 0;
            for(int i = stopien - 1; i >= 0; i--)
            {
                mult = 1;
                for(int j = 0; j < i; j++)
                {
                    mult *= (wartoscSzukana - tempCos[j].X);
                }

                mult *= tempCos[i].Y;
                sum += mult;
            }

            return sum;
        }
    }
}