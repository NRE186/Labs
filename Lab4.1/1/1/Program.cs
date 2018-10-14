using System;
using static System.Console;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(ReadLine());
            int b = Int32.Parse(ReadLine());
            int res = a * b;
            int x = 0b00010000;
            WriteLine(x);
            ReadKey();
        }
    }
}
