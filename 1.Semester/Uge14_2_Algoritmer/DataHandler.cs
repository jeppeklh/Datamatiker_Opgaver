using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14_Algoritmer
{
    public class DataHandler(string dataFileName)
    {
        public string DataFileName { get; } = dataFileName;

        public void SaveStudent(Student student)
        {
            try
            {
                StreamWriter sw = new StreamWriter(DataFileName);
                sw.WriteLine(student.MakeTitle());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public Student LoadStudent()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string[] sArray = sr.ReadLine().Split(", ");
            Student person = new Student(sArray[0], int.Parse(sArray[1]));
            sr.Close();
            return person;
        }

        public void SaveStudents(Student[] students)
        {
            try
            {
                StreamWriter sw = new StreamWriter(DataFileName);
                for (int i = 0; i < students.Length; i++)
                {
                    sw.WriteLine(students[i].MakeTitle());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public Student[] LoadStudents()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string[] lines = sr.ReadToEnd().Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Student[] students = new Student[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] sArray = lines[i].Split(", ");
                students[i] = new Student(sArray[0], int.Parse(sArray[1]));
            }
            sr.Close();
            return students;
        }  
    }
}
