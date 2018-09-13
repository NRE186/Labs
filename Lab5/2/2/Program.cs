using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10,x = 0;
            int[,] mas = new int[n, n];
            Random rand = new Random();

            Console.WriteLine("Первоначальный массив");

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    mas[i, j] = rand.Next(-50, 50);
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if(mas[i,j] < 0)
                    {
                        x++;
                    }
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Колличество отрицательных элементов - " + x);

            Console.ReadKey();
        }
    }
}
