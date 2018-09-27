using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите eps");
            double sum = 0, eps = 0, a;
            double x = 1.5;
            eps = Convert.ToDouble(Console.ReadLine());
            int i = 3;
            int z = 5;
            a = (1 / i* Math.Pow(x, i)) + (1 / i* Math.Pow(x, z));
            while (a > eps)
            {
                sum += a;
                i += 2;
                z += 2;
                a = (1 / i* Math.Pow(x, i)) + (1 / i* Math.Pow(x, z));
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
