using System;

namespace s4
{
    class Program
    {
        static void Main(string[] args)
        {/*
            tube A = new tube();
            A.addbeg(1);
            A.addbeg(2);
            A.addbeg(3);
            A.addbeg(4);
            A.addend(5);
            A.addend(6);
            A.addend(7);
            A.delbeg();
            A.delend();
            A.view();
            Console.WriteLine();
            Console.ReadKey();
            Stack B = new Stack();
            */

            LPO lpo = new LPO();
            lpo.Push(10);
            lpo.Push(12);
            lpo.Push(7);
            lpo.Push(13);
            lpo.Push(7);
            lpo.Push(1);
            lpo.Push(11);
            lpo.Push(11);
            lpo.Push(5);
            lpo.Push(2);
            lpo.Push(2);
            lpo.Push(1);
            lpo.Push(0);

            lpo.Pop(5);
            lpo.Pop(2);
            lpo.Pop(2);
            lpo.Pop(2);

            lpo.view();
            lpo.stergereAll();
            lpo.view();
        }
    }
}
