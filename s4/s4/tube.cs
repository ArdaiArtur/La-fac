﻿using System;
using System.Collections.Generic;
using System.Text;

namespace s4
{
   public class tube
    {
       private int []values;
        public tube()
        { values = new int[0]; 
        
        
        }
        public void addbeg(int x)
        {
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length; i++)
                temp[i + 1] = values[i];
            temp[0] = x;
            values = temp;
        }
        public void addend (int x)
        {

            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i];
            temp[values.Length] = x;
            values = temp;
        }
        public int delbeg()
        {
            int toReturn = values[0];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i + 1];
            values = temp;
            return toReturn;
        }

        public int delend()
        {
            int toReturn = values[values.Length-1];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i ];
            values = temp;
            return toReturn;
        }
        public virtual void view()
        { for (int i = 0; i < values.Length; i++)
                Console.Write(values[i]+" ");
            Console.WriteLine();
        }

    }
}
