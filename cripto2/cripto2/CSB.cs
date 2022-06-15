using System;
using System.Collections.Generic;
using System.Text;

namespace cripto2
{
    class CSB : ICipher
    {
       
      
        protected string key;
       protected string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
       
       // StringBuilder sb = new StringBuilder();
       public CSB()
        {
            plainText = chiperText = "";
        }
        public void Decriptare()
        {
            throw new NotImplementedException();
        }

        public void Encript()
        {
            int offset=0; StringBuilder sb = new StringBuilder();
            foreach (char item in plainText)
            {
                if (char.IsLower(item))
                { offset = item - 'a'; }
                else if (char.IsUpper(item))
                { offset = item - 'A'; }
                if(char.IsLetter(item))
                { 
                    if (char.IsUpper(item))
                        { sb.Append(key[offset]); } 
                    else
                sb.Append(char.ToLower(key[offset]));
                }
                else
                sb.Append(item);

            }
            chiperText= sb.ToString();
        }

        private string plainText;
        public string PlainText
            {
            get{
                //Decriptare();
                return plainText;}
    set {plainText=value;}
}
        
        private string chiperText;
        public string ChiperText
        {
            get {
                //Encript();
                return chiperText; }
            set { chiperText = value; }
        }
    }
}
