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
            double x1, x2, y1, y2;
            double d1 = -10;
            double d2 = 10;
            double eps = 0.0001;
            double dx = 0.1;
            x1 = d1;
            x2 = x1 + dx;
            y1 = F(x1);
            do
            {
                y2 = F(x1);
                if (y1 * y2 < 0)
                {
                    Console.WriteLine(string.Format("{0:0.00}", "[" + Math.Round((x1 - dx), 2) + ";" + Math.Round(x1,2) + "]"));
                }
                x1 = x2;
                x2 = x1 + dx;
                y1 = y2;
            }
            while (x1 < d2);

            //Метод бисекции


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