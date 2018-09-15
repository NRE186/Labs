using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string[] words = { "яблоко", "гидрокарбонат ", "программирование", "химия", "windows", "искуственный"};
            for (int i = 0; i < 6; i++)
            {
                if (res < words[i].Length)
                {
                    res = words[i].Length;
                }
            }
            Console.WriteLine("В самом длинном слове " + res + " букв");
            Console.ReadKey();
        }
    }
}
