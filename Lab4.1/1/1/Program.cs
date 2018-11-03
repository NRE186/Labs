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
            bin.ShowBin(x);
            bin.ZeroReverse(x,a);

            Console.WriteLine("Задание 11");
            int[] b = {8, 9, 10, 11, 12, 13 };
            x = 58937;
            bin.ShowBin(x);
            bin.SwapBits(x,b);

            Console.WriteLine("Задание 19");
            Console.ReadKey();
        }
    }
}
