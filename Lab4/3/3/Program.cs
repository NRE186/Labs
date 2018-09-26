using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите eps");
            double eps = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x");
            int x = Console.Read();
            double sum = 1/x;
            int i = 3;
            int z = 5;
            while (sum > eps)
            {
                sum = sum - (1 / i* Math.Pow(x,i)) + (1 / i * Math.Pow(x, z));
                i += 2;
                z += 2;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
