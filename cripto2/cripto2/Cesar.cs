using System;
using System.Collections.Generic;
using System.Text;

namespace cripto2
{
    class Cesar:CSB
    {
        public Cesar()
        {   
            
            key = alphabet.Substring(3) + alphabet.Substring(0, 3);
            
        }
    }
}
