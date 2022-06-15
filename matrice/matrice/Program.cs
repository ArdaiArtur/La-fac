using System;
using System.IO;
using System.Threading;
namespace matrice
{
    class Program
    {
        public static int[,] load(string nume)
        {
            TextReader load = new StreamReader("../../" + nume);
            string []buffer = load.ReadLine().Split(' ');
            int n = int.Parse(buffer[0]);
            int m = int.Parse(buffer[1]);
            int[,] v = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] s = load.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    v[i, j] = int.Parse(s[j]);
                }

             }
            return v;
        }

        public static void view(int[,]v)
        {
            for (int i = 0; i < v.GetLength(0); i++)
            { for (int j = 0; j< v.GetLength(1); j++)
                {
                    Console.Write(v[i, j]+" ");
                }
                Console.WriteLine();
                        }
        }

        public static void matricemaimare(int[,] v)
        {

            int[,] w = new int[v.GetLength(0) * 2 - 1, v.GetLength(1) * 2 - 1];
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {

                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        w[i, j] = v[i / 2, j / 2];
                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        w[i, j] = (v[i / 2, j / 2] + v[i / 2, (j / 2) + 1]) / 2;
                    }
                }

            }
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    if (i % 2 != 0)
                    {
                        w[i, j] = 0;
                        w[i, j] = (w[i - 1, j] + w[i + 1, j]) / 2;
                    }
                }
               

            }
            view(w);
        }
        static void Main(string[] args)
        {
            int[,] a = load("data.txt");
            view(a);
            matricemaimare(a);
        }
    }
}
