using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace leetcideexer
{
    class Program
    {
        public static int[] KWeakestRows(int[][]mat, int k)
        {
            int[] ind = new int[mat.Length];

            int[] sum = new int[mat.Length];
            int db = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum[i] = mat[i].Sum();
                ind[i] = i;
            }
            Array.Sort(ind, (a, b) =>
            {
                int sumc = sum[a].CompareTo(sum[b]);
                return sumc == 0 ? a.CompareTo(b) : sumc;
            });

            var res = new int[k];
            Array.Copy(ind, res, k);
            return res;

            
        }

        public static bool ContainsDuplicate(int[] num)
        {
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (set.ContainsKey(num[i]))
                    return true;
                else
                    set.Add(num[i], i);
            }
            return false;
        }

        public static int MaxSubArray(int[] num)
        {
            int sum = 0;
            int c = 0;
        
            for (int i = 0; i < num.Length; i++)
            {       
                c = c + num[i]; 
                sum = Math.Max(sum, c);
                if (sum < 0) sum = 0;
            }
            return sum;
        }

        public static int Search(int[] num, int target)
        {
            int n = num.Length-1;
            int left = 0;
            int calc = 0;
            while(left<=n)
            {
                calc = left + (n-left)/2;
                if (num[calc] == target) return calc;
                if (calc < target) left = calc + 1;
                else
                    n = calc - 1;

            }
            return -1;
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int f = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                if (nums[i] < target)
                    f++;
                else break;

            }
            return f;
        }
        public static int[][] UpdateMatrix(int[][] a)
        {
            Queue<int[]> que = new Queue<int[]>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[0].Length; j++)
                {
                    if (a[i][j] == 1)
                        que.Enqueue(new int[] { i, j });
                }
            }
            Queue<int[]> qw = new Queue<int[]>();
            while (que.Count>0)
            {int db = 0;
               var s= que.Dequeue();
                qw.Enqueue(s);
                
                
                    while(qw.Count>0)
                    { 
                    var point = qw.Dequeue();
                    
                    if (ifokeBFS(point[0] - 1, point[1], a) && a[point[0] - 1][point[1]] == 0)
                    { a[point[0]][point[1]] = a[point[0]][point[1]]+1; break; }
                    else if (ifokeBFS(point[0] + 1, point[1], a) && a[point[0] + 1][point[1]] == 0)
                    { a[point[0]][point[1]] = a[point[0]][point[1]] + 1; break; }
                    else if (ifokeBFS(point[0], point[1] - 1, a) && a[point[0]][point[1] - 1] == 0)
                    { a[point[0]][point[1]] = a[point[0]][point[1]] + 1; break; }
                    else if (ifokeBFS(point[0], point[1] + 1, a) && a[point[0] - 1][point[1] + 1] == 0)
                    { a[point[0]][point[1]] = a[point[0]][point[1]] + 1; break; }
                    if (ifokeBFS(point[0]-1, point[1], a) && a[point[0] - 1][point[1] ] == 1)
                        que.Enqueue(new int[] {point[0]-1,point[1] });
                    if (ifokeBFS(point[0]+1, point[1], a) && a[point[0] + 1][point[1] ] == 1)
                        que.Enqueue(new int[] { point[0] +1, point[1] });
                    if (ifokeBFS(point[0], point[1]-1, a) && a[point[0]][point[1] -1 ] == 1)
                        que.Enqueue(new int[] { point[0], point[1]-1 });
                    if (ifokeBFS(point[0], point[1]+1, a) && a[point[0] ][point[1] + 1] == 1)
                        que.Enqueue(new int[] { point[0] , point[1]+1 });


                }
                qw.Clear();
            }
            return a;
        }
        public  static bool ifokeBFS(int j, int i,int [][]a)
        {
            if (i >= 0 && i < a.Length && j >= 0 && j < a[0].Length)
                return true;
            return false;
        
        }
        public static void RotateArray(int []ary,int k)
        {
            Queue<int> que = new Queue<int>();
            for (int i = ary.Length -k; i < ary.Length ; i++)
            {
                que.Enqueue(ary[i]);
            }

            for (int i = 0; i < ary.Length - k; i++)
            {
                que.Enqueue(ary[i]);
            }
           
            ary = que.ToArray();
            for (int i = 0; i <ary.Length; i++)
            {
                Console.Write(ary[i] + " ");
            }

        }

        public static void Movezeros(int[] nums)
        {
            int a = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                { nums[a] = nums[i]; }
                if (i > a)
                    nums[i] = 0;
            }
        
        }

        public static void permutari(int[] a, int n, int k, bool[] b,int []ary)
        {
            if (k >= n)
            {

                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {if (!b[i])
                    {
                        b[i] = true;
                        a[k] = ary[i];
                        permutari(a, n, k + 1, b,ary);
                        b[i] = false;
                    }
                }
            
            
            }
        
        }
        static void Main(string[] args)
        {/*UPDATE MATIRX
            int[][] matrix = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                matrix[i] = new int[3];
            }
            matrix[0][0] = 0; matrix[0][1] = 0; matrix[0][2] = 0;
            matrix[1][0] = 0; matrix[1][1] = 1; matrix[1][2] = 0;
            matrix[2][0] = 1; matrix[2][1] = 1; matrix[2][2] = 1;

            matrix = UpdateMatrix(matrix);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i][j] + " ");

                }
                Console.WriteLine();
            }
            */
            int[] ary = new int[] {1,2,3,4,5,6,7 };
            // RotateArray(ary,3);
            int n = 4;
            bool[] b = new bool[n];
            int[] ads = new int[] {1,2,3,4 };
            int[] a = new int[n] ;
            permutari(a, n, 0, b,ads);

            Console.ReadKey();
        }
    }
}
