using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fam = { "Рахманинов", "Иванов", "Петров", "Сидоров", "Дмитров", "Радович", "Беляев", "Белов" };
            for (int i = 0; i < 8; i++)
            {
                if (fam[i].Length == 6 || fam[i].Length == 7)
                {
                    Console.WriteLine(fam[i]);
                }
            }
            Console.ReadKey();
        }
    }
}