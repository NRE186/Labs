using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char ch1 = s[0];
            char ch5 = s[4];
            char[] a = s.ToCharArray();
            a[0] = ch5;
            a[4] = ch1;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
