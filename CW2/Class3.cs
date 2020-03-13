using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace CW2
{
    [Serializable]
    public class University
    {
        [JsonProperty("Author: ")]
        public string author;

        [JsonProperty("Created At: ")]
        public string date;

        [JsonProperty("Students: ")]
        public HashSet<Student> students;

        [JsonProperty("Active Studies: ")]
        public Dictionary<string, int> asc;

        public University(HashSet<Student> students, Dictionary<string, int> asc)
        {
            date = DateTime.Now.ToString("dd.MM.yyyy");
            author = "Artem Anikieiev";
            this.students = students;
            this.asc = asc;
        }
    }
}
