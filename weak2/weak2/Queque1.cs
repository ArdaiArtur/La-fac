using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace weak2
{
    internal class Queque1
    {
       public int[] values;
        public Queque1()
        {
            values = new int[0];

        }
        public void Push(int ValueToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = values.Length-1; i >= 0; i--)
                temp[i+1] = values[i];
            temp[0] = ValueToAdd;
            values = temp;
        }
        public int Pop()
        {
            int toReturn = values[values.Length - 1];
            int[] Temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length-1; i++)
                Temp[i] = values[i+1];
            values = Temp;
            return toReturn;
        }
        public void view() {
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i] + " ");
            
                    
                    }
       


    }
}