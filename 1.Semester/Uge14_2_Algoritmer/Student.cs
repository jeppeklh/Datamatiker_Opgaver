using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14_Algoritmer
{
    public class Student
    {

        public string FullName;
        public int GroupNumber;

        public Student(string fullName, int groupNumber)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
        }

        public string MakeTitle()
        {
            return $"{FullName}, {GroupNumber}";
        }
    }
}