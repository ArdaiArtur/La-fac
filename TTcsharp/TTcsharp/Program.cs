using System;
using System.Collections.Generic;

namespace TTcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            person pre = new person();
           // Console.WriteLine(pre.id);
            float f = 10.12f;
            long l = 200L;
            Console.WriteLine(f + l);
            int i = 2;
            Console.WriteLine(++i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

        }
    }
    public class person
    {
        public int id;
    }
}

