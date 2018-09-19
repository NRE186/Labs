using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fam = { "Рахманинов", "Иванов", "Петров", "Сидоров", "Дмитров", "Радович", "Беляев", "Аршавин" };
            for (int i = 0; i < 8; i++)
            {
                string val = "Ра";
                if (fam[i].Contains(val))
                {
                    Console.WriteLine(fam[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
