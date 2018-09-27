using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, i, eps = 0, a;
            Console.WriteLine("Введите точность: ");
            eps = Convert.ToDouble(Console.ReadLine());
            sum = 0.5;
            i = 3;
            a = (1/i) - (1/(i + 1));
            while (a > eps)
            {
                sum += a;
                i += 2;
                a = (1 / i) - (1 / i + 1);
            }
            Console.WriteLine("Сумма ряда = " + sum);
            Console.ReadKey();
        }
    }
}
