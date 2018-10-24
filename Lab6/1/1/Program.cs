using System;

namespace ConsoleApplication8
{
    class Program
    {
        static bool[] Prost(int n) // метод для нахождения простых чисел с помощью решета Эратосфена
        {
            bool[] m = new bool[n + 1];
            for (int i = 2; i <= n; ++i)
            {
                if (m[i] == false)
                {
                    for (int j = 1; i + i * j <= n; ++j)
                    {
                        m[i + i * j] = true;
                    }
                }
            }
            return m;
        }
        static void Main(string[] args)
        {
            {
                int n = Convert.ToInt32(Math.Floor((Math.Sqrt(600851475143))));
                bool[] m = Prost(n);
                long ans = 2;
                for (int i = n; i > 2; --i)
                {
                    if ((m[i] == false) && 600851475143 % i == 0)
                    {
                        ans = i;
                        break;
                    }
                }
                Console.WriteLine(ans);
                Console.ReadKey();
            }
        }
    }
}