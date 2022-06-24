using System;

namespace weak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queque1 A = new Queque1();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Push(4);
            A.Push(5);
            A.Push(6);
            A.Push(7);
            A.Push(8);
            A.Pop();
            A.Push(1);
            A.view();
            Console.ReadKey();
        }
    }
}
