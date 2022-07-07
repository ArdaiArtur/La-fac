using System;
using System.Collections.Generic;
using System.Text;

namespace lectia_56
{
    class permutari
    {
       public static void back(int k, int n, int[] sol, bool[] vis,int [,]ma)
        {
            
            if (k >= n)
            {
                bool ok = true;
                for (int i = 0; i < n-1; i++)
                {
                    if (ma[sol[i], sol[i+1]] == 0)
                        ok = false;
                    
                }
                for (int i = 0; i < n; i++)
                {
                    if (ok == true)
                    {
                        Console.Write(sol[i] + " ");

                    }
                }
                if (ok == true) Console.WriteLine(); 
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        sol[k] = i + 1;
                        back(k + 1, n, sol, vis,ma);
                        vis[i] = false;
                    }
                }
            }
        }
    }
        
}
