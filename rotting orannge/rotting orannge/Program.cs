using System;
using System.IO;
using System.Collections.Generic;

namespace rotting_orannge
{
    class Program
    {

        static void Main(string[] args)
        {
            //cream gridul cu care luram
            int[][] grid = new int[3][];
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new int[3];
            }
            int db = -1;
            int[,] ad = new int[3, 3];
            Queue<int[]> que = new Queue<int[]>();
            grid[0][0] = 2; grid[0][1] = 1; grid[0][2] = 1;
            grid[0][1] = 1; grid[0][0] = 1; grid[1][2] = 0; 
            grid[0][2] = 0; grid[2][1] = 1; grid[2][2] = 1;

            ad[0,0] = 2; ad[0, 1] = 1; ad[0, 2] = 1;
            ad[1, 0] = 1; ad[1, 1] = 1; ad[1, 2] = 0;
            ad[2, 0] = 0; ad[2, 1] = 1; ad[2, 2] = 1;
            //punem in que toate elementele care e egal cu 2
            for (int i = 0; i < ad.GetLength(0); i++)
            {
                for (int j = 0; j < 3;j++)
                {
                    if (ad[i,j] == 2)
                        que.Enqueue(new int[] { i, j });

                }
            }
            bool[,] b = new bool[grid.Length, grid[0].Length];
            Console.WriteLine(que.Count);
            while (que.Count >0)
            {
                db++;
               
                for (int i = 0; i < que.Count; i++)
                {
                    var loc = que.Dequeue();
                    b[loc[0],loc[1]]= true;
                    if (eok(loc[0], loc[1] + 1, ad) && !b[loc[0], loc[1] + 1])
                        que.Enqueue(new int[] { loc[0], loc[1] + 1 });

                    if (eok(loc[0], loc[1] - 1, ad) && !b[loc[0], loc[1] - 1])
                        que.Enqueue(new int[] { loc[0], loc[1] - 1 });

                    if (eok(loc[0]+1, loc[1], ad) && !b[loc[0]+1, loc[1]])
                        que.Enqueue(new int[] { loc[0]+1, loc[1]   });

                    if (eok(loc[0]-1, loc[1], ad) && !b[loc[0]-1, loc[1]])
                        que.Enqueue(new int[] { loc[0]-1, loc[1] });
               }
            
            }
            Console.WriteLine($"miscarile necesare sa parcurge gridul {db}");



        }

      
        
        //daca e ok locati  si e egal 1
        public static bool eok(int i, int j, int[,] a)
        {
            if (i >= 0 && i < a.GetLength(0) && j >= 0 && j < a.GetLength(1) && a[i,j] == 1)
            {
                a[i,j] = 2;
                return true;
            }
            return false;
        
        
        }
    }
}
