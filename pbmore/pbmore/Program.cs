using System;

namespace pbmore
{
    class Program
    {public static int[] numereleunuicifre(ulong n)
        { ulong s = n;
          
            int[] v = new int[10];
            while (s != 0)
            {
                v[s % 10]++;
                s = s / 10;
            }
            return v;
        }

        public static void sumatotcif(int[] v)
        {
            int[] a = new int[v.Length];
            int db = 0;int ddbb = 0;
            int S = 0; int D = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != 0)
                    while (db != v[i])
                    {
                        S = S * 10 + v[i];
                        db++;
                        ddbb++;
                    }
                db = 0;
            } int x = 1;
            for(int i=1;i<=ddbb;i++)
            { x = x * i; }
            db = 0;
            do
            {



            } while (db != x);
        }
        public static int permutacion(int n)
        {
            int k = 1;
            int[] x = new int[100];
            while (k > 0)
            {
                bool gasit = false;
                do
                {
                    x[k]++; 
                    if (x[k] <= n)
                        gasit = true;
                } while (!gasit && x[k] <= n);
                if (!gasit)
                {
                    k--;
                }
                else
                    if (k < n)
                {
                    k++;
                    x[k] = 0;
                }
                else
                    for (int i = 1; i < n; i++)
                    { }

            }

        }
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            sumatotcif(numereleunuicifre(n));

        }
    }
}
