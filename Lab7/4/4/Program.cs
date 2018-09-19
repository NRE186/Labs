using System;
using System.Collections.Generic;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> family = new List<string>();
            string[] fam = { "Рахманинов", "Иванов", "Петров", "Сидоров", "Дмитров", "Радович", "Беляев", "Аршавин" };
            for (int i = 0; i < 8; i++)
            {
                string val = "Ра";
                if (fam[i].Contains(val))
                {
                    family.Add(fam[i]);
                }
            }
            foreach (string f in family)
            {
                Console.Write(f + " ");
            }
            Console.ReadKey();
        }
    }
}
