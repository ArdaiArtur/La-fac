using System;
using System.Collections.Generic;
using System.Text;

namespace cripto2
{
    class Rotn:CSB
    {
        public Rotn(int n)
        { key = alphabet.Substring(n % 26) + alphabet.Substring(0, n % 26);
        
        }
    }
}
