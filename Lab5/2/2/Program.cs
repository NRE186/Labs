using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            List<int> elm = new List<int>();
            int[,] mas = new int[n, n];
            Random rnd = new Random(DateTime.Now.Millisecond);

            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(-50, 50);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mas[i,j] < 0)
                    {
                        elm.Add(mas[i,j]);
                    }
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Отрицательные числа");
            foreach (int s in elm)
            {
                Console.Write(s + " ");
            }
            Console.ReadKey();
        }
    }
}
