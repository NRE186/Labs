using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите eps");
            double eps = Convert.ToDouble(Console.ReadLine());
            double sum = 0.5;
            int i = 3;
            while (sum > eps)
            {
                sum = sum +  (1 / i) - (1 / i + 1);
                i += 2;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
