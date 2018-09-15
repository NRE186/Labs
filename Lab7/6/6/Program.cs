using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[8];
            string[] fam = { "Рахманинов", "Иванов", "Петров", "Сидоров", "Дмитров", "Радович", "Беляев", "Белов" };
            for (int i = 0; i < 8; i++)
            {
                if (fam[i].Length == 6 || fam[i].Length == 7)
                {
                    a[i] = fam[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (a[i] != null)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadKey();
        }
    }
}