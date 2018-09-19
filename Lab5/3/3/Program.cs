using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elm = new List<int>();
            int res = 0;
            int s = 0;
            int[,] mas = new int[4, 5];
            Random rnd = new Random();

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < x && mas[i,j] % 2 == 0)
                    {
                        elm.Add(mas[i, j]);
                        res++;
                        s += mas[i, j];
                    }
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Колличество элементов меньших " + x + " и кратных двум - " + res);
            Console.WriteLine("Сумма этих элементов = " + s);
            Console.ReadKey();
        }
    }
}
