using System;
using System.Collections.Generic;
using System.Text;

namespace lectia3simult
{
    class Queue
    {
        Data[] values;

        public Queue()
        {
            values = new Data[0];
        }
        public bool isEmpty()
        {
            if (values.Length == 0)
            {
                return true;
            }
            return false;
        }
        public void Push(Data ValueToAdd)
        {
            Data[] temp = new Data[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
                temp[i + 1] = values[i];
            temp[0] = ValueToAdd;
            values = temp;
        }

        public Data Pop()
        {
            Data toReturn = values[values.Length - 1];
            Data[] temp = new Data[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
                temp[i] = values[i];
            values = temp;
            return toReturn;
        }

        public void view()
        {
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i].view());
        }
    }
}

