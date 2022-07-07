using System;
using System.IO;
namespace lectia_56
{
    class Program
    {
        static void Main(string[] args)
        {



           
            TextReader load = new StreamReader(@"..\..\data.in");
            int n = int.Parse(load.ReadLine());
            int[,] ma = new int[n+1, n+1];
            string buffer;
            while ((buffer=load.ReadLine()) != null)
            {
                string[] da = buffer.Split(' ');
                int x = int.Parse(da[0]);
                int y = int.Parse(da[1]);
                ma[x, y ] = 1;
                ma[y, x ] = 1;
            }
               
            for(int i = 1; i <= n; i++) 
                {
                    for (int j = 1; j <= n; j++)
                        Console.Write(ma[i, j] + " ");
                    Console.WriteLine();

                }
            
 bool hasisland = false;
            for (int i = 0; i < n; i++)
            {
                bool local = true;

                for (int j = 0; j < n; j++)
                {
                    if (ma[i, j] == 1)
                        local = false;
                }
                    if(local)
                { hasisland = true;
                    break;
                }



            }
                if (hasisland)
                { Console.WriteLine("hasisland; da"); }
               else
                { Console.WriteLine("hasisland; nu"); }


            bool hasgradinpar = false;
            bool euler = true;int nrimp = 0;
            for (int i = 0; i < n; i++)
            {

                int sum = 0;
                for (int j = 0; j < n; j++)
                    sum += ma[i, j];
                if ((sum % 2) == 1)
                {
                    nrimp++;
                     hasgradinpar = true;
                    if (nrimp > 2)
                    {
                        euler = false;
                        break;
                    }

                }

            }
            if (euler)
                Console.WriteLine(" euler;DA");
            else
                Console.WriteLine(" euler;NU");

            if (!hasgradinpar)
                Console.WriteLine("ciclu eulerian");
            
           for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(ma[i, j] + " ");
                Console.WriteLine();

            }
            Console.WriteLine(ma.Length);
            int[] sol = new int[n];
            bool[] vis = new bool[n];
            permutari a = new permutari();
            permutari.back(0, n, sol, vis,ma);
            Console.ReadKey();
            
        }
    }
}
