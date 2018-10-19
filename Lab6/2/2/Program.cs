using System;
using System.Collections.Generic;
using static System.Console;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[,] mas = new int[n, n];
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<int> elm = new List<int>();
            int res = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(0, 20);
                }
            }
            //Поиск 4 подряд идущих чисел, у которых произведение > res
            //Поиск слева направо
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 3; j++)
                {
                    if (mas[i,j] * mas[i, j + 1] * mas[i, j + 2] * mas[i, j + 3] > res)
                    {
                        
                        elm.Clear();
                        res = mas[i, j] * mas[i, j + 1] * mas[i, j + 2] * mas[i, j + 3];
                        elm.Add(mas[i, j]);
                        elm.Add(mas[i, j + 1]);
                        elm.Add(mas[i, j + 2]);
                        elm.Add(mas[i, j + 3]);
                    }
                }
            }
            //Поиск сверху вниз
            for (int i = 0; i < n - 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] * mas[i + 1, j] * mas[i + 2, j] * mas[i + 3, j] > res)
                    {

                        elm.Clear();
                        res = mas[i, j] * mas[i + 1, j] * mas[i + 2, j] * mas[i + 3, j];
                        elm.Add(mas[i, j]);
                        elm.Add(mas[i, j + 1]);
                        elm.Add(mas[i, j + 2]);
                        elm.Add(mas[i, j + 3]);
                    }
                }
            }
            //Поиск справа налево
            for (int i = 0; i < n; i++)
            {
                for (int j = n-1; j > 2; j--)
                {
                    if (mas[i, j] * mas[i, j - 1] * mas[i, j - 2] * mas[i, j - 3] > res)
                    {

                        elm.Clear();
                        res = mas[i, j] * mas[i, j - 1] * mas[i, j - 2] * mas[i, j - 3];
                        elm.Add(mas[i, j]);
                        elm.Add(mas[i, j - 1]);
                        elm.Add(mas[i, j - 2]);
                        elm.Add(mas[i, j - 3]);
                    }
                }
            }
            //Поиск снизу вверх
            for (int i = n-1; i > 2; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] * mas[i - 1, j] * mas[i - 2, j] * mas[i - 3, j] > res)
                    {

                        elm.Clear();
                        res = mas[i, j] * mas[i - 1, j] * mas[i - 2, j] * mas[i - 3, j];
                        elm.Add(mas[i, j]);
                        elm.Add(mas[i, j - 1]);
                        elm.Add(mas[i, j - 2]);
                        elm.Add(mas[i, j - 3]);
                    }
                }
            }
            //Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Write(mas[i, j] + " ");
                }
                WriteLine();
            }
            WriteLine();
            foreach (int s in elm)
            {
                Write(s + " ");
            }
            WriteLine();
            Write(res);
            ReadKey();
        }
    }
}
