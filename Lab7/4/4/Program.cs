using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[8];
            string[] fam = { "Рахманинов", "Иванов", "Петров", "Сидоров", "Дмитров", "Радович", "Беляев", "Ра" };
            for (int i = 0; i < 8; i++)
            {
                string val = "Ра";
                if (fam[i].Contains(val))
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
