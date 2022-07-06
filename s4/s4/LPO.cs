using System;
using System.Collections.Generic;
using System.Text;

namespace s4
{
    class LPO
    {
        private int[] values;
        public LPO()
        {
            values = new int[0];


        }
        public void addbeg(int x)
        {
            int[] temp = new int[values.Length+1 ];
            for (int i = 0; i < values.Length; i++)
                temp[i + 1] = values[i];
            temp[0] = x;
            values = temp;
        }
        public void addend(int x)
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
            int toReturn = values[values.Length - 1];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i];
            values = temp;
            return toReturn;
        }


        public void Push(int x)
        {
            int db = 0;
            for(int a=0;a<values.Length;a++)
            { if (values[a] == x)
                    db++;
                        }
            if (db == 0)
            {
                if (values.Length == 0 || x <= values[0])
                    addbeg(x);
                else if (x >= values[values.Length - 1])
                    addend(x);
                else
                {
                    int idx = 0;
                    while (values[idx] < x)
                        idx++;
                    int[] temp = new int[values.Length + 1];
                    for (int i = 0; i < idx; i++)
                        temp[i] = values[i];
                    temp[idx] = x;
                    for (int i = idx; i < values.Length; i++)
                        temp[i + 1] = values[i];
                    values = temp;



                }
            }
            else Console.WriteLine("arg aparut numarul deja");
        }
        public void stergereAll()
        {
            int[] temp = new int[1];
            
            values = temp;
        }
        public void Pop(int key)
        {
            if (values[0] == key)
                delbeg();
            else
                if (values[values.Length - 1] == key)
                delend();
            else
            {
                int idx = -1;
                for (int i = 1; i < values.Length-1; i++)
                    if(values[i]==key)
                    {

                        idx = i;
                        break;
                    }
                if (idx != -1)
                { int[] temp = new int[values.Length - 1];
                    for (int i = 0; i < idx; i++)
                        temp[i] = values[i];
                    for (int i = idx; i < values.Length - 1; i++)
                        temp[i] = values[i + 1];
                    values = temp;
                        }



            }



        }


        public virtual void view()
        {
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i] + " ");
            Console.WriteLine();
        }

    }
}
