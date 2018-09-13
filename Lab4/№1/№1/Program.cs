using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25, a = 1;
            double x,s = 1;
            for (int i = 1; i < 25; i++){
                double b = i * i + 1;
                x = a / b;
                s += x;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
