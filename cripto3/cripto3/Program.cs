using System;
using System.Text;

namespace cripto3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "attackatdawn";
            string key = "LEMONLEMONLE";
            onetimepad(message, key);
            onetimepadXOR(message, key);
        }
        public static void onetimepadXOR(string message, string key)
        {
            if (message.Length > key.Length)
            {
                throw new ArgumentException("nu se poate face criptarea lungimea mesjului e mai mare decat key");

            }
            byte[] arraymesseg = Encoding.Unicode.GetBytes(message);
            byte[] arraykey = Encoding.Unicode.GetBytes(key);
            byte[] crypt= transformXor(arraymesseg, arraykey);
            byte[] decrypt = transformXor(crypt, arraykey);
            string decript = Encoding.Unicode.GetString(decrypt);
            Console.WriteLine(decript);
        }

        private static byte[] transformXor(byte[] arraymesseg, byte[] arraykey)
        {byte[] result=new byte [arraymesseg.Length];
            for (int i = 0; i < arraymesseg.Length; i++)
            {
                result[i] = (byte)(arraymesseg[i] ^arraykey[i]);
            }
            return result;
        }

        public static void onetimepad(string message, string key)
        {  string cyphertext=Transform(message,key,(x,y)=>(x+y)%26);
            string decrypt = Transform(cyphertext, key, (x, y) => (x - y+26) % 26);
            Console.WriteLine(cyphertext);
            Console.WriteLine(decrypt);
        
        }

        private static string Transform(string message, string key, Func<int,int,int>func)
        {
        if(message.Length>key.Length)
            {
                throw new ArgumentException("nu se poate face criptarea lungimea mesjului e mai mare decat key");

            }
            string abphabet = "ABCDEFGHIJKLMNOPQRSTUVWXZ";
            StringBuilder codtext = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                int offset1 = 0, offset2 = 0;
                if (char.IsLetter(message[i]))
                {
                    offset1 = char.ToUpper(message[i]) - 'A';
                }
                else
                { continue; }
                
                if (char.IsLetter(key[i]))
                {
                    offset2 = char.ToUpper(key[i]) - 'A';
                }
                else
                { continue; }
                int ofset = func(offset1,offset2);
                char c = (char)(char.IsLower(message[i]) ? 'a' + ofset : 'A' + ofset);
                
                codtext.Append(c);
            }
            
            return codtext.ToString();
        }

    }
}
