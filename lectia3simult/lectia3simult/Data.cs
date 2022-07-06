using System;
using System.Collections.Generic;
using System.Text;

namespace lectia3simult
{
    class Data
    {
        public int l, v, c;
        public Data(int l,int v,int c)
        {
            this.l = l;
            this.v = v; 
            this.c = c;
        }
        public string view()
        {
            return "("+l+" "+c+" "+v+")";
        }
    }
}
