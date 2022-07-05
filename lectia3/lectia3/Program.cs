using System;

namespace lectia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack tempRpn = new Stack();
            Console.WriteLine("Hello World!");
            string s = "5 1+3*2 5*3 4 2+ * - +";
            string[] local = s.Split(' ');
            foreach (string st in local)
                if(st[0]>='0'&& st[0]<='9')
                
                    tempRpn.Push(int.Parse(st));
                else {
                    int t1 = tempRpn.Pop();
                    int t2 = tempRpn.Pop();
                    switch(st[0])
                    {
                        case '+':tempRpn.Push(t2 + t1);break;
                        case '*': tempRpn.Push(t2 * t1); break;
                        case '-': tempRpn.Push(t2 - t1); break;
                        case '/': tempRpn.Push(t2 / t1); break;
                    }
                }
            tempRpn.view();
            Console.ReadKey();
             
        }
    }
}
