using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[8, 7];
            Random rand = new Random();

            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = rand.Next(-20, 20);

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            for (var i = 0; i < mas.GetLength(0); i++)
                for (var j = 0; j < mas.GetLength(1); j++)
                    for (var k = 0; k < mas.GetLength(1); k++)
                    {
                        if (mas[i, j] >= mas[i, k]) continue;
                        var temp = mas[i, j];
                        mas[i, j] = mas[i, k];
                        mas[i, k] = temp;
                    }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}