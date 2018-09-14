using System;

namespace ConsoleApplication8
{
    class Program
    {
        static long  Divd(long  N, long  start)
        {
            for ( long i = start; i * i <= N; i += 2)
            {
                if (N % i == 0) return i;
            }
            return N;
        }
        static void Main(string[] args)
        {
            long N = 600851475143;
            long start = 3;

            while (N > 1)
            {
                start = Divd(N, start);
                N /= start;
            }
            Console.WriteLine(start);
            Console.ReadKey();
        }
    }
}