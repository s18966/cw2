using System;
using System.Collections.Generic;
using System.Text;

namespace CW2
{
    class Student
    {
        public string Imie;
        public string Nazwisko;
        public string NazwaStudiow;
        public string TypStudiow;
        public string Index;
        public string DataUrodzenia;
        public string Email;
        public string ImieMatki;
        public string ImieOjca;

        public Student(string imie, string nazwisko, string nazwaStudiow, string typStudiow, string index, string dataUrodzenia, string email, string imieMatki, string imieOjca)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NazwaStudiow = nazwaStudiow;
            Index = index;
            DataUrodzenia = dataUrodzenia;
            Email = email;
            ImieMatki = imieMatki;
            ImieOjca = imieOjca;
        }
        public override  string ToString()
        {
            return Imie + " " + Nazwisko + " " + NazwaStudiow + " " + TypStudiow + " " + Index + " " + DataUrodzenia + " " + Email + " " + ImieMatki + " " + ImieOjca; 
        }
    }
}
