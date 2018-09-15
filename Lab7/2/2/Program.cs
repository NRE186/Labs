using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string s = Console.ReadLine();
            s = s.ToLower();
            int l = s.Length;
            for (int i = 0; i < l; i++)
            {
                if (s[i] == 'и')
                x++;
            }
            Console.WriteLine("И встречается " + x + " раз");
            Console.ReadKey();
        }
    }
}
