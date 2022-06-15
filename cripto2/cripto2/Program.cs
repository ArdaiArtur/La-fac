using System;

namespace cripto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cesar c = new Cesar();
            c.PlainText = "Helloz";
            c.Encript();

            Console.WriteLine($"{c.ChiperText}");
            MAS masc = new MAS();
        }
    }
}
