using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elm = new List<int>();
            int n = 10,x = 0;
            int[,] mas = new int[n, n];
            Random rnd = new Random();

            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    mas[i, j] = rnd.Next(-50, 50);
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if(mas[i,j] < 0)
                    {
                        x++;
                        elm.Add(mas[i,j]);
                    }
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Колличество отрицательных элементов - " + x);
            Console.WriteLine("Отрицательные числа");
            foreach (int s in elm)
            {
                Console.Write(s + " ");
            }
            Console.ReadKey();
        }
    }
}
