using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // x^3+3e^2x=0
        static void Main(string[] args)
        {
            //Получение отрезков
            double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double d1 = -10;
            double d2 = 10;
            double dx = 0.1;
            x1 = d1;
            x2 = x1 + dx;
            y1 = F(x1);
            do
            {
                y2 = F(x1);
                if (y1 * y2 < 0)
                {
                    break;
                }
                x1 = x2;
                x2 = x1 + dx;
                y1 = y2;
            }
            while (x1 < d2);
            x2 = x1 - dx;
            Console.WriteLine("Отрезок");
            Console.WriteLine("[" + Math.Round(x2, 2) + ";" + Math.Round(x1, 2) + "]");
            //Метод бисекции
            double eps = 0.000001;
            double c = 0;
            double x = 0;
            double fc = 0;
            double err = c;

            while (Math.Abs(x1 - x2) > eps)
            {
                c = x1 + 0.5 * (x2 - x1);
                fc = F(c);
                if (Math.Abs(fc) < eps) break;
                if (F(x1) * F(c) < 0)
                    x2 = c;
                else
                    x1 = c;
            }
            Console.WriteLine("Метод бисекции ");
            Console.WriteLine(Math.Round(c,7));
            Console.ReadKey();
        }
        static double F(double x)
        {
            double F;
            F = x*x*x +  3 * Math.Exp(2 * x);
            return F;
        }
    }
}