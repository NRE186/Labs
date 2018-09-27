using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int z = 5;
            const int y = 4;
            List<int> elm = new List<int>();
            int s = 0;
            int[,] mas = new int[z, y];
            Random rnd = new Random(DateTime.Now.Millisecond);

            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                }
            }
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mas[i, j] < x && mas[i,j] % 2 == 0)
                    {
                        elm.Add(mas[i, j]);
                        s += mas[i, j];
                    }
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма этих элементов = " + s);
            Console.ReadKey();
        }
    }
}
