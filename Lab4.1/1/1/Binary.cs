using System;

namespace _1
{
    class Binary
    {
        public void ShowBin(long x)
        {
            for (int i = 31; i >= 0; i--)
                Console.Write((x >> i) & 1);
            Console.WriteLine();
        }
        public void ZeroReverse(int x, int[] a)
        {
            ShowBin(x);
            for (int i = 0; i < a.Length; i++)
            {
                x &= ~(1 << a[i]);
            }
            ShowBin(x);
        }
        public void SwapBits(long x)
        {
            ShowBin(x);
            long c, t;
            c = (x >> 9) & 1;
            t = (x >> 8) & 1;
            x = x & ~((1 << 9) | (1 << 8)) | (c << 8) | (t << 9);
            ShowBin(x);
            c = (x >> 11) & 1;
            t = (x >> 10) & 1;
            x = x & ~((1 << 11) | (1 << 10)) | (c << 10) | (t << 11);
            c = (x >> 13) & 1;
            t = (x >> 12) & 1;
            x = x & ~((1 << 13) | (1 << 12)) | (c << 12) | (t << 13);
            ShowBin(x);
        }
        public void Zero(long x, long a)
        {
            ShowBin(x);
            for (int i = 31; i > a; i--)
                x &= ~(1 << (i));
            ShowBin(x);
        }
    }
}
