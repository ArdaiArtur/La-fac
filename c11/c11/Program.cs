using System;
using System.IO;
using System.Threading.Tasks;
namespace c11
{
    class Program
    {
        public static int[,] inflie()
        {
            TextReader load = new StreamReader(@"..\..\subgraf1.in");
            int n = int.Parse(load.ReadLine())+1;
            string buffer;
            int[,] a = new int[n, n];
            while ((buffer = load.ReadLine()) != null)
            {
                int x = int.Parse(buffer.Split(' ')[0]);
                int y = int.Parse(buffer.Split(' ')[1]);
                a[x, y]++;
                a[y, x]++;

            }
            return a;
        }

        public static  async Task afara(int v)
        { 
       using StreamWriter afara= new StreamWriter(@"..\..\subgraf1.out");

          
               await afara.WriteLineAsync(Convert.ToString(v));
            
        }
        public static int elimina(int[,] v)
        { int min = 100;int d = 0;
            int []a = new int[v.GetLength(0)];
            
            for (int i = 1; i < v.GetLength(0); i++)
            {
                int c = 0;
                for (int j = 1; j < v.GetLength(1); j++)
                {
                    if (v[i, j] == 1) c++;          
                }
                if (c < min) min = c;
                a[i] = c;
            }
            for (int i = 1; i < v.GetLength(0); i++)
            {
                if (a[i] != min)
                        d++;
            }
            return d;

        }
        public static void man(int[,] v)
        {    
            int min = 100; int d = 0;
            int[] a = new int[v.GetLength(0)];

            for (int i = 1; i < v.GetLength(0); i++)
            {
                int c = 0;
                for (int j = 1; j < v.GetLength(1); j++)
                {
                    if (v[i, j] == 1) c++;
                }
                if (c <= min) { min = c; d++; }
                a[i] = c;
            }
            int[,] x = new int[v.GetLength(0) - d, v.GetLength(1) - d];
            int g = 1,l=1;
            Console.WriteLine(d);
            for (int i = 1; i < v.GetLength(0); i++)
            {
                if (a[i] == min)
                    i++;
                for (int j = 1; j < v.GetLength(1); j++)
                {
                    if (a[j] == min) j++;
                    x[g, l] = v[i, j];
                    Console.Write(v[i, j] + " ");
                    l++;
                }
                Console.WriteLine();
                g++;
                l = 1;
            }

            for (int i = 1; i < x.GetLength(0); i++)
            {
                for (int j = 1; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string nume = "subgraf1.in";
            afara(elimina(inflie()));
            man(inflie());
            Console.ReadKey();
        }
    }
}
