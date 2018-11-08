using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary bin = new Binary();

            Console.WriteLine("Задание 3");
            int[] a = { 3, 5, 7 };
            int x = 760;
            bin.ZeroReverse(x,a);
            Console.WriteLine(new String('-', 32));
            Console.WriteLine("Задание 11");
            x = 58937;
            bin.SwapBits(x);
            Console.WriteLine(new String('-', 32));
            Console.WriteLine("Задание 19");
            x = 58937;
            bin.Zero(x,5);
            Console.ReadKey();
        }
    }
}
