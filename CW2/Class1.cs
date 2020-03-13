using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace CW2
{
    public class Student
    {
        [JsonProperty("imie")]
        public string Imie;
        [JsonProperty("nazwisko")]
        public string Nazwisko;
        [JsonProperty("Studies")]
        public Studies studies;
        [JsonProperty("Index")]
        public string Index;
        [JsonProperty("DataUrodzenia")]
        public string DataUrodzenia;
        [JsonProperty("Email")]
        public string Email;
        [JsonProperty("ImieMatki")]
        public string ImieMatki;
        [JsonProperty("ImieOjca")]
        public string ImieOjca;
        

        public Student(string imie, string nazwisko, Studies studies, string index, string dataUrodzenia, string email, string imieMatki, string imieOjca)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            this.studies = studies;
            Index = index;
            DataUrodzenia = dataUrodzenia;
            Email = email;
            ImieMatki = imieMatki;
            ImieOjca = imieOjca;
        }
        public override  string ToString()
        {
            return Imie + " " + Nazwisko + "  " + Index + " " + DataUrodzenia + " " + Email + " " + ImieMatki + " " + ImieOjca; 
        }
    }
}
