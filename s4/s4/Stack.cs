using System;
using System.Collections.Generic;
using System.Text;

namespace s4
{
    public class Stack: tube
    {
        public Stack() : base()
        { }

        public void Push(int x)
        { addbeg(x); }
        public int Pop()
        {
            return delbeg();

        }
        public  override void view()
        { base.view(); }



    }
}
