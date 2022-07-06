using System;
using System.Collections.Generic;
using System.Text;

namespace s4
{
    class Queue :tube
    {
       
        
            public Queue() : base()
            { }

            public void Push(int x)
            { addbeg(x); }
            public int Pop()
            {
                return delbeg();

            }
            public override void view()
            { base.view(); }



        
    }
}
