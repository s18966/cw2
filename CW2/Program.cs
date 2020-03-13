using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Xml.Linq;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = args[0];
            var lines = File.ReadLines(path);
            var pathToSave = args[1];
            var logFilePath = @"C:\Users\kinAtrA\Desktop\cw2\CW2\log.txt";
            if (!File.Exists(logFilePath))
            {
                StreamWriter sw = File.CreateText(logFilePath);
            }

            var logFile = new StreamWriter(logFilePath);

            string form = args[3];
            HashSet<Student> students = new HashSet<Student>(new MyComp());
            foreach(var line in lines)
            {
                var tmpArr = line.Split(',');
                if(Array.IndexOf(tmpArr, "") > -1){
                    logFile.WriteLine("Blank spaces: " + line.ToString());
                }
                else if (tmpArr.Length != 9)
                {
                    logFile.WriteLine("Not good notation: " + line.ToString());
                    
                }
                else
                {
                   
                    Studies stud = new Studies();
                    stud.imie= tmpArr[2];
                    stud.typ = tmpArr[3];
                    Student tmp = new Student(tmpArr[0], tmpArr[1], stud, tmpArr[4], tmpArr[5], tmpArr[6], tmpArr[7], tmpArr[8]);

                    students.Add(tmp);
                }
            }
            logFile.Close();
            Dictionary<String, int> activeStudentsCount = new Dictionary<string, int>();
            foreach(var student in students)
            {
                if (!activeStudentsCount.ContainsKey(student.studies.imie))
                {
                    activeStudentsCount.Add(student.studies.imie, 1);
                }
                else
                {
                    activeStudentsCount[student.studies.imie]++;
                }
                if (form.Equals("xml"))
                {

                    Console.WriteLine("xml");
                    XDocument doc = new XDocument(new XElement("university",
                        new XAttribute("createdAt", DateTime.Now.ToString("dd.MM.yyyy")),
                        new XAttribute("author", "Artem Anikieiev"),
                        new XElement("studenci",
                            from stud in students
                            select new XElement("student",
                                new XAttribute("indexNumber", stud.Index),
                                new XElement("name", stud.Imie),
                                new XElement("secondName", student.Nazwisko),
                                new XElement("birthdate", student.DataUrodzenia),
                                new XElement("email", student.Email),
                                new XElement("mothersName", student.ImieMatki),
                                new XElement("fathersName", student.ImieOjca),
                                new XElement("studies",
                                    new XElement("name", student.studies.imie),
                                    new XElement("mode", student.studies.typ)
                                ))),
                        new XElement("activeStudies",
                            from asc in activeStudentsCount
                            select new XElement("studies",
                                new XAttribute("name", asc.Key),
                                new XAttribute("numberOfStudents", asc.Value)
                            )
                        )));
                    doc.Save(pathToSave + ".xml");

                }
                else if (form.Equals("json"))
                {

                    Console.WriteLine("Json");
                    University uni = new University(students, activeStudentsCount);

                    var json = JsonConvert.SerializeObject(uni, (Newtonsoft.Json.Formatting)Formatting.Indented);
                    File.WriteAllText(pathToSave + ".json", json);

                }
                else
                {
                    Console.WriteLine("Wrong format");
                }
            }
        }
    }
}

