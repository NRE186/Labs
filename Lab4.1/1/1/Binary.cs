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
            for(int i = 0; i < a.Length; i++)
            {
                x &= ~(1 << a[i]);
            }
            ShowBin(x);
        }
        public void SwapBits(long s, int[] a)
        {
            long x = s;
            //for (int i = 0; i < a.Length/2; i++)
            //{
            //    long c = (x >> a[i + 1]) & 1;
            //    long t = (x >> a[i]) & 1;
            //    x = x & ~((1 << a[i + 1]) | (1 << a[i])) | (c << a[i]) | (t << a[i + 1]);
            //}

            long c = (x >> 9) & 1;
            long t = (x >> 8) & 1;
            x = x & ~((1 << 9) | (1 << 8)) | (c << 8) | (t << 9);
            c = (x >> 11) & 1;
            t = (x >> 10) & 1;
            x = x & ~((1 << 11) | (1 << 10)) | (c << 10) | (t << 11);
            c = (x >> 13) & 1;
            t = (x >> 12) & 1;
            x = x & ~((1 << 13) | (1 << 12)) | (c << 12) | (t << 13);
            ShowBin(x);
        }
    }
}
