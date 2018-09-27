using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int l = s.Length;
            string res;
            res = (l == 7) ? "Слово состоит из 7 символов" : "В слове не 7 символов" ;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}