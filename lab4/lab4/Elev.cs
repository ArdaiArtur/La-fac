using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Elev
    {
        public string Nume;
        public string Prenume;
        public int Nota;
        public static List<Elev> CitesteElevi()
        {
            //se creeeaza o lista cu elemente de tip Elev
            List<Elev> elevi = new List<Elev>();
            //lista este populata cu patru obiecte de tip Elev
            //Informatiile despre elevi se seteaza cu ajutorul proprietatilor
            //Nume, Prenume si Nota declarate anterior
            elevi.Add(new Elev()
            { Nume = "Popescu", Prenume = "Daniel", Nota = 9 });
            elevi.Add(new Elev()
            { Nume = "Pop", Prenume = "Crina", Nota = 10 });
            elevi.Add(new Elev()
            { Nume = "Georgescu", Prenume = "Alina", Nota = 8 });
            elevi.Add(new Elev()
            { Nume = "Anton", Prenume = "Andreea", Nota = 7 });
            //lista poate continua
            //dupa creare si populare, lista este returnata de catre metoda
            //CitesteElevi()
            return elevi;
        }
    }
}
