using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolacjaNewtona
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

        static double[] b;
        static double[] x_k;
        static double[] x;
        static void Main(string[] args)
        {
            b = new double[10];
            
            x = new double[10];
            x_k = new double[10];

            CalcElements(x, 10, 10);
        }

        static void CalcElements(double[] x, int order, int step)
        {
            int i;
            double[] xx;
            if (order >= 1)
            {
                xx = new double[order];
                for (i = 0; i < order - 1; i++)
                {
                    xx[i] = (x[i + 1] - x[i]) / (x_k[i + step] - x_k[i]);
                }
                b[step - 1] = x[0];
                CalcElements(xx, order - 1, step + 1);
            }

        }
    }
}
