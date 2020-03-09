using System;
using System.Collections.Generic;
using System.IO;

namespace CW2
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\Users\s18966\Desktop\cw2\CW2\dane.csv";
            var lines = File.ReadLines(path);
            
            var logFilePath = @"C:\Users\s18966\Desktop\cw2\CW2\log.txt";
            if (!File.Exists(logFilePath))
            {
                StreamWriter sw = File.CreateText(logFilePath);
            }

            var logFile = new StreamWriter(logFilePath);

            string typ = "xml";
            ICollection<Student> students = new List<Student>();
            foreach(var line in lines)
            {
                var tmpArr = line.Split(',');
                if(Array.IndexOf(tmpArr, "") > -1){
                    logFile.WriteLine(line.ToString());
                }
                else if (tmpArr.Length != 9)
                {
                    logFile.WriteLine(line.ToString());

                }
                else
                {

                    students.Add(new Student(tmpArr[0], tmpArr[1], tmpArr[2], tmpArr[3], tmpArr[4], tmpArr[5], tmpArr[6], tmpArr[7], tmpArr[8]));
                    
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
     
    }
}
