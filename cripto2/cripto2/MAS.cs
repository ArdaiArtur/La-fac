using System;
using System.Collections.Generic;
using System.Text;

namespace cripto2
{
    class MAS:CSB
    {
        public MAS()
        { key = alphabet;
            char[] keyChars = key.ToCharArray();
            int j;
            char aux;
            Random rnd = new Random();
            // amestecam aleator din key 
            for(int i=keyChars.Length-1;i>0;i--)
            {
                j = rnd.Next(i+1);
                aux = keyChars[i];
                keyChars[i] = keyChars[j];
                keyChars[j] = aux;
            }
            key = new string(keyChars);
            Console.WriteLine(key);
        }

       

        
    }
}
