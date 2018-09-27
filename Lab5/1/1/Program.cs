using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 7;
            const int y = 8;
            int[,] mas = new int[x, y];
            Random rnd = new Random(DateTime.Now.Millisecond);
            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    mas[i, j] = rnd.Next(-20, 20);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            for (var i = 0; i < x; i++)
                for (var j = 0; j < y; j++)
                    for (var k = 0; k < y; k++)
                    {
                        if (mas[i, j] >= mas[i, k]) continue;
                        var temp = mas[i, j];
                        mas[i, j] = mas[i, k];
                        mas[i, k] = temp;
                    }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}